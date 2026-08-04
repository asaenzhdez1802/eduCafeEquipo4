using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmMisVentasCajero : Form
    {
        
        private const int COLUMNA_FOLIO = 0;
        private const int COLUMNA_ACCIONES = 1;
        private const int COLUMNA_FECHA = 2;
        private const int COLUMNA_HORA = 3;
        private const int COLUMNA_PRODUCTOS = 4;
        private const int COLUMNA_TOTAL = 5;
        private const int COLUMNA_METODO_PAGO = 6;


        private bool columnaMetodoPagoExiste;
        private bool columnaEstadoExiste;

        public frmMisVentasCajero()
        {
            InitializeComponent();
            ConectarEventos();
        }

        private void ConectarEventos()
        {
   

            Load -= frmMisVentasCajero_Load;
            Load += frmMisVentasCajero_Load;

            btnPuntoVenta.Click -= btnPuntoVenta_Click;
            btnPuntoVenta.Click += btnPuntoVenta_Click;

            btnCerrarSesion.Click -= btnCerrarSesion_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;

            btnFiltrar.Click -= btnFiltrar_Click;
            btnFiltrar.Click += btnFiltrar_Click;

            btnLimpiarFiltros.Click -=
                btnLimpiarFiltros_Click;

            btnLimpiarFiltros.Click +=
                btnLimpiarFiltros_Click;

            dgvHistorialVentas.CellClick -=
                dgvHistorialVentas_CellClick;

            dgvHistorialVentas.CellClick +=
                dgvHistorialVentas_CellClick;

            btnMisVentas.Enabled = false;
        }

        private void frmMisVentasCajero_Load(
            object sender,
            EventArgs e)
        {
            if (!ValidarSesion())
            {
                return;
            }

            ConfigurarFormulario();
            DetectarColumnasOpcionales();
            ConfigurarFiltros();

           
             
            CargarResumenVentas();
            CargarVentas();
        }

      

        private bool ValidarSesion()
        {
            if (!SesionActual.HaySesionActiva)
            {
                MessageBox.Show(
                    "No existe una sesión activa. Inicia sesión nuevamente.",
                    "Sesión no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                MostrarLogin();
                return false;
            }

            if (!SesionActual.Rol.Equals(
                "Cajero",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Esta sección solamente está disponible para cajeros.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                SesionActual.CerrarSesion();
                MostrarLogin();

                return false;
            }

            return true;
        }

        private void ConfigurarFormulario()
        {
            lblSubtitulo.Text =
                $"Ventas realizadas por {SesionActual.NombreCompleto}";

            dgvHistorialVentas.AllowUserToAddRows = false;
            dgvHistorialVentas.AllowUserToDeleteRows = false;
            dgvHistorialVentas.AllowUserToResizeRows = false;
            dgvHistorialVentas.ReadOnly = true;
            dgvHistorialVentas.MultiSelect = false;

            dgvHistorialVentas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistorialVentas.ClearSelection();

            lblNotaHistorial.Text =
                "Historial de ventas del cajero actual.";
        }

        

        private void DetectarColumnasOpcionales()
        {
            columnaMetodoPagoExiste = false;
            columnaEstadoExiste = false;

            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string consulta = @"
                        SELECT COLUMN_NAME
                        FROM INFORMATION_SCHEMA.COLUMNS
                        WHERE TABLE_SCHEMA = DATABASE()
                          AND TABLE_NAME = 'venta'
                          AND COLUMN_NAME IN
                          (
                              'metodo_pago',
                              'estado'
                          );";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector =
                        comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string columna =
                                lector["COLUMN_NAME"].ToString();

                            if (columna.Equals(
                                "metodo_pago",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                columnaMetodoPagoExiste = true;
                            }

                            if (columna.Equals(
                                "estado",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                columnaEstadoExiste = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible revisar la estructura de la tabla venta.\n\n" +
                    ex.Message,
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        private void ConfigurarFiltros()
        {
            dtpFechaInicio.Format =
                DateTimePickerFormat.Custom;

            dtpFechaInicio.CustomFormat =
                "dd/MM/yyyy";

            dtpFechaFin.Format =
                DateTimePickerFormat.Custom;

            dtpFechaFin.CustomFormat =
                "dd/MM/yyyy";

            dtpFechaInicio.Value =
                DateTime.Today.AddDays(-30);

            dtpFechaFin.Value =
                DateTime.Today;

            ConfigurarFiltroMetodoPago();
            ConfigurarFiltroEstado();

            dgvHistorialVentas.Rows.Clear();
            dgvHistorialVentas.ClearSelection();
        }

        private void ConfigurarFiltroMetodoPago()
        {
            cmbMetodoPagoFiltro.Items.Clear();
            cmbMetodoPagoFiltro.Items.Add("Todos");

            if (!columnaMetodoPagoExiste)
            {
                cmbMetodoPagoFiltro.SelectedIndex = 0;
                cmbMetodoPagoFiltro.Enabled = false;
                return;
            }

            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        cmbMetodoPagoFiltro.Enabled = false;
                        cmbMetodoPagoFiltro.SelectedIndex = 0;
                        return;
                    }

                    string consulta = @"
                        SELECT DISTINCT metodo_pago
                        FROM venta
                        WHERE id_usuario = @idUsuario
                          AND metodo_pago IS NOT NULL
                          AND TRIM(metodo_pago) <> ''
                        ORDER BY metodo_pago;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(
                            "@idUsuario",
                            MySqlDbType.Int32
                        ).Value = SesionActual.IdUsuario;

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string metodo =
                                    lector["metodo_pago"].ToString();

                                if (!cmbMetodoPagoFiltro
                                    .Items.Contains(metodo))
                                {
                                    cmbMetodoPagoFiltro.Items.Add(
                                        metodo
                                    );
                                }
                            }
                        }
                    }
                }

                cmbMetodoPagoFiltro.Enabled = true;
                cmbMetodoPagoFiltro.SelectedIndex = 0;
            }
            catch
            {
                cmbMetodoPagoFiltro.Enabled = false;
                cmbMetodoPagoFiltro.SelectedIndex = 0;
            }
        }

        private void ConfigurarFiltroEstado()
        {
            cmbEstadoFiltro.Items.Clear();
            cmbEstadoFiltro.Items.Add("Todos");

            if (!columnaEstadoExiste)
            {
                cmbEstadoFiltro.SelectedIndex = 0;
                cmbEstadoFiltro.Enabled = false;
                return;
            }

            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        cmbEstadoFiltro.Enabled = false;
                        cmbEstadoFiltro.SelectedIndex = 0;
                        return;
                    }

                    string consulta = @"
                        SELECT DISTINCT estado
                        FROM venta
                        WHERE id_usuario = @idUsuario
                          AND estado IS NOT NULL
                          AND TRIM(estado) <> ''
                        ORDER BY estado;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(
                            "@idUsuario",
                            MySqlDbType.Int32
                        ).Value = SesionActual.IdUsuario;

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string estado =
                                    lector["estado"].ToString();

                                if (!cmbEstadoFiltro
                                    .Items.Contains(estado))
                                {
                                    cmbEstadoFiltro.Items.Add(
                                        estado
                                    );
                                }
                            }
                        }
                    }
                }

                cmbEstadoFiltro.Enabled = true;
                cmbEstadoFiltro.SelectedIndex = 0;
            }
            catch
            {
                cmbEstadoFiltro.Enabled = false;
                cmbEstadoFiltro.SelectedIndex = 0;
            }
        }

  

        private void CargarResumenVentas()
        {
            DateTime hoy = DateTime.Today;
            DateTime finDia = hoy.AddDays(1);

            int diasDesdeLunes =
                ((int)hoy.DayOfWeek -
                (int)DayOfWeek.Monday + 7) % 7;

            DateTime inicioSemana =
                hoy.AddDays(-diasDesdeLunes);

            DateTime finSemana =
                inicioSemana.AddDays(7);

            DateTime inicioMes =
                new DateTime(
                    hoy.Year,
                    hoy.Month,
                    1
                );

            DateTime finMes =
                inicioMes.AddMonths(1);

            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        LimpiarTarjetas();
                        return;
                    }

                    string consulta = @"
                        SELECT
                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicioDia
                                         AND fecha_hora < @finDia
                                        THEN total
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS monto_dia,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicioDia
                                         AND fecha_hora < @finDia
                                        THEN 1
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS cantidad_dia,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicioSemana
                                         AND fecha_hora < @finSemana
                                        THEN total
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS monto_semana,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicioSemana
                                         AND fecha_hora < @finSemana
                                        THEN 1
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS cantidad_semana,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicioMes
                                         AND fecha_hora < @finMes
                                        THEN total
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS monto_mes,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicioMes
                                         AND fecha_hora < @finMes
                                        THEN 1
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS cantidad_mes

                        FROM venta
                        WHERE id_usuario = @idUsuario;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(
                            "@idUsuario",
                            MySqlDbType.Int32
                        ).Value = SesionActual.IdUsuario;

                        comando.Parameters.Add(
                            "@inicioDia",
                            MySqlDbType.DateTime
                        ).Value = hoy;

                        comando.Parameters.Add(
                            "@finDia",
                            MySqlDbType.DateTime
                        ).Value = finDia;

                        comando.Parameters.Add(
                            "@inicioSemana",
                            MySqlDbType.DateTime
                        ).Value = inicioSemana;

                        comando.Parameters.Add(
                            "@finSemana",
                            MySqlDbType.DateTime
                        ).Value = finSemana;

                        comando.Parameters.Add(
                            "@inicioMes",
                            MySqlDbType.DateTime
                        ).Value = inicioMes;

                        comando.Parameters.Add(
                            "@finMes",
                            MySqlDbType.DateTime
                        ).Value = finMes;

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            if (!lector.Read())
                            {
                                LimpiarTarjetas();
                                return;
                            }

                            decimal montoDia =
                                Convert.ToDecimal(
                                    lector["monto_dia"]
                                );

                            int cantidadDia =
                                Convert.ToInt32(
                                    lector["cantidad_dia"]
                                );

                            decimal montoSemana =
                                Convert.ToDecimal(
                                    lector["monto_semana"]
                                );

                            int cantidadSemana =
                                Convert.ToInt32(
                                    lector["cantidad_semana"]
                                );

                            decimal montoMes =
                                Convert.ToDecimal(
                                    lector["monto_mes"]
                                );

                            int cantidadMes =
                                Convert.ToInt32(
                                    lector["cantidad_mes"]
                                );

                            decimal ticketPromedio = 0;

                            if (cantidadMes > 0)
                            {
                                ticketPromedio =
                                    montoMes / cantidadMes;
                            }

                            lblMontoDia.Text =
                                "$ " + montoDia.ToString("N2");

                            lblCantidadDia.Text =
                                FormatearCantidadVentas(
                                    cantidadDia
                                );

                            lblMontoSemana.Text =
                                "$ " + montoSemana.ToString("N2");

                            lblCantidadSemana.Text =
                                FormatearCantidadVentas(
                                    cantidadSemana
                                );

                            lblMontoMes.Text =
                                "$ " + montoMes.ToString("N2");

                            lblCantidadMes.Text =
                                FormatearCantidadVentas(
                                    cantidadMes
                                );

                            lblMontoTicket.Text =
                                "$ " +
                                ticketPromedio.ToString("N2");

                            lblPeriodoTicket.Text =
                                "Este mes";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LimpiarTarjetas();

                MessageBox.Show(
                    "No fue posible cargar el resumen de ventas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private string FormatearCantidadVentas(
            int cantidad)
        {
            if (cantidad == 1)
            {
                return "1 venta";
            }

            return cantidad + " ventas";
        }

        private void LimpiarTarjetas()
        {
            lblMontoDia.Text = "$ 0.00";
            lblCantidadDia.Text = "0 ventas";

            lblMontoSemana.Text = "$ 0.00";
            lblCantidadSemana.Text = "0 ventas";

            lblMontoMes.Text = "$ 0.00";
            lblCantidadMes.Text = "0 ventas";

            lblMontoTicket.Text = "$ 0.00";
            lblPeriodoTicket.Text = "Este mes";
        }

       

        private void CargarVentas()
        {
            if (!ValidarSesion())
            {
                return;
            }

            DateTime fechaInicio =
                dtpFechaInicio.Value.Date;

            DateTime fechaFin =
                dtpFechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show(
                    "La fecha de inicio no puede ser mayor que la fecha final.",
                    "Fechas incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string metodoSeleccionado =
                cmbMetodoPagoFiltro.SelectedItem?.ToString()
                ?? "Todos";

            string estadoSeleccionado =
                cmbEstadoFiltro.SelectedItem?.ToString()
                ?? "Todos";

            bool filtrarMetodo =
                columnaMetodoPagoExiste &&
                !metodoSeleccionado.Equals(
                    "Todos",
                    StringComparison.OrdinalIgnoreCase
                );

            bool filtrarEstado =
                columnaEstadoExiste &&
                !estadoSeleccionado.Equals(
                    "Todos",
                    StringComparison.OrdinalIgnoreCase
                );

            try
            {
                dgvHistorialVentas.Rows.Clear();

                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string campoMetodoPago =
                        columnaMetodoPagoExiste
                        ? "COALESCE(v.metodo_pago, 'No registrado')"
                        : "'No registrado'";

                    StringBuilder consulta =
                        new StringBuilder();

                    consulta.AppendLine(@"
                        SELECT
                            v.id_venta,
                            v.fecha_hora,
                            v.total,

                            COALESCE(
                                SUM(dv.cantidad),
                                0
                            ) AS cantidad_productos,");

                    consulta.AppendLine(
                        campoMetodoPago +
                        " AS metodo_pago"
                    );

                    consulta.AppendLine(@"
                        FROM venta AS v

                        LEFT JOIN detalle_venta AS dv
                            ON dv.id_venta = v.id_venta

                        WHERE v.id_usuario = @idUsuario
                          AND v.fecha_hora >= @fechaInicio
                          AND v.fecha_hora < @fechaFin");

                    if (filtrarMetodo)
                    {
                        consulta.AppendLine(
                            "AND v.metodo_pago = @metodoPago"
                        );
                    }

                    if (filtrarEstado)
                    {
                        consulta.AppendLine(
                            "AND v.estado = @estado"
                        );
                    }

                    consulta.AppendLine(@"
                        GROUP BY
                            v.id_venta,
                            v.fecha_hora,
                            v.total");

                    if (columnaMetodoPagoExiste)
                    {
                        consulta.AppendLine(
                            ", v.metodo_pago"
                        );
                    }

                    consulta.AppendLine(@"
                        ORDER BY
                            v.fecha_hora DESC;");

                    using (MySqlCommand comando =
                        new MySqlCommand(
                            consulta.ToString(),
                            conexion
                        ))
                    {
                        comando.Parameters.Add(
                            "@idUsuario",
                            MySqlDbType.Int32
                        ).Value = SesionActual.IdUsuario;

                        comando.Parameters.Add(
                            "@fechaInicio",
                            MySqlDbType.DateTime
                        ).Value = fechaInicio;

                        comando.Parameters.Add(
                            "@fechaFin",
                            MySqlDbType.DateTime
                        ).Value = fechaFin.AddDays(1);

                        if (filtrarMetodo)
                        {
                            comando.Parameters.Add(
                                "@metodoPago",
                                MySqlDbType.VarChar
                            ).Value = metodoSeleccionado;
                        }

                        if (filtrarEstado)
                        {
                            comando.Parameters.Add(
                                "@estado",
                                MySqlDbType.VarChar
                            ).Value = estadoSeleccionado;
                        }

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                int idVenta =
                                    Convert.ToInt32(
                                        lector["id_venta"]
                                    );

                                DateTime fechaHora =
                                    Convert.ToDateTime(
                                        lector["fecha_hora"]
                                    );

                                int cantidadProductos =
                                    Convert.ToInt32(
                                        lector[
                                            "cantidad_productos"
                                        ]
                                    );

                                decimal total =
                                    Convert.ToDecimal(
                                        lector["total"]
                                    );

                                string metodoPago =
                                    lector["metodo_pago"]
                                    .ToString();

                               
                                int indiceFila =
                                    dgvHistorialVentas.Rows.Add(
                                        "VTA-" +
                                        idVenta.ToString("D5"),

                                        "Ver",

                                        fechaHora.ToString(
                                            "dd/MM/yyyy"
                                        ),

                                        fechaHora.ToString(
                                            "HH:mm"
                                        ),

                                        cantidadProductos,

                                        "$ " +
                                        total.ToString("N2"),

                                        metodoPago
                                    );

                                dgvHistorialVentas
                                    .Rows[indiceFila]
                                    .Tag = idVenta;
                            }
                        }
                    }
                }

                dgvHistorialVentas.ClearSelection();

                int cantidadEncontrada =
                    dgvHistorialVentas.Rows.Count;

                lblNotaHistorial.Text =
                    cantidadEncontrada == 1
                    ? "ⓘ Se encontró 1 venta en el rango seleccionado."
                    : "ⓘ Se encontraron " +
                      cantidadEncontrada +
                      " ventas en el rango seleccionado.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar el historial de ventas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void dgvHistorialVentas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != COLUMNA_ACCIONES)
            {
                return;
            }

            object identificador =
                dgvHistorialVentas.Rows[e.RowIndex].Tag;

            if (identificador == null)
            {
                return;
            }

            int idVenta =
                Convert.ToInt32(identificador);

            MostrarDetalleVenta(idVenta);
        }

        private void MostrarDetalleVenta(int idVenta)
        {
            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string campoMetodoPago =
                        columnaMetodoPagoExiste
                        ? "COALESCE(v.metodo_pago, 'No registrado')"
                        : "'No registrado'";

                    string consulta = $@"
                        SELECT
                            v.id_venta,
                            v.fecha_hora,
                            v.total,
                            v.monto_recibido,
                            v.cambio,

                            {campoMetodoPago}
                                AS metodo_pago,

                            p.nombre AS producto,
                            dv.cantidad,
                            dv.precio_unitario,
                            dv.subtotal

                        FROM venta AS v

                        LEFT JOIN detalle_venta AS dv
                            ON dv.id_venta = v.id_venta

                        LEFT JOIN producto AS p
                            ON p.id_producto = dv.id_producto

                        WHERE v.id_venta = @idVenta
                          AND v.id_usuario = @idUsuario

                        ORDER BY p.nombre ASC;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(
                            "@idVenta",
                            MySqlDbType.Int32
                        ).Value = idVenta;

                        comando.Parameters.Add(
                            "@idUsuario",
                            MySqlDbType.Int32
                        ).Value = SesionActual.IdUsuario;

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            StringBuilder detalle =
                                new StringBuilder();

                            bool ventaEncontrada = false;
                            int numeroProducto = 1;

                            while (lector.Read())
                            {
                                if (!ventaEncontrada)
                                {
                                    ventaEncontrada = true;

                                    DateTime fechaHora =
                                        Convert.ToDateTime(
                                            lector["fecha_hora"]
                                        );

                                    decimal total =
                                        Convert.ToDecimal(
                                            lector["total"]
                                        );

                                    decimal montoRecibido =
                                        Convert.ToDecimal(
                                            lector["monto_recibido"]
                                        );

                                    decimal cambio =
                                        Convert.ToDecimal(
                                            lector["cambio"]
                                        );

                                    string metodoPago =
                                        lector["metodo_pago"]
                                        .ToString();

                                    detalle.AppendLine(
                                        "Folio: VTA-" +
                                        idVenta.ToString("D5")
                                    );

                                    detalle.AppendLine(
                                        "Fecha: " +
                                        fechaHora.ToString(
                                            "dd/MM/yyyy HH:mm"
                                        )
                                    );

                                    detalle.AppendLine(
                                        "Cajero: " +
                                        SesionActual.NombreCompleto
                                    );

                                    detalle.AppendLine(
                                        "Método de pago: " +
                                        metodoPago
                                    );

                                    detalle.AppendLine(
                                        "Total: $" +
                                        total.ToString("N2")
                                    );

                                    detalle.AppendLine(
                                        "Monto recibido: $" +
                                        montoRecibido.ToString("N2")
                                    );

                                    detalle.AppendLine(
                                        "Cambio: $" +
                                        cambio.ToString("N2")
                                    );

                                    detalle.AppendLine();
                                    detalle.AppendLine("Productos:");
                                    detalle.AppendLine(
                                        "--------------------------------"
                                    );
                                }

                                if (lector["producto"] ==
                                    DBNull.Value)
                                {
                                    continue;
                                }

                                string producto =
                                    lector["producto"].ToString();

                                int cantidad =
                                    Convert.ToInt32(
                                        lector["cantidad"]
                                    );

                                decimal precioUnitario =
                                    Convert.ToDecimal(
                                        lector["precio_unitario"]
                                    );

                                decimal subtotal =
                                    Convert.ToDecimal(
                                        lector["subtotal"]
                                    );

                                detalle.AppendLine(
                                    numeroProducto + ". " +
                                    producto
                                );

                                detalle.AppendLine(
                                    "   " +
                                    cantidad +
                                    " x $" +
                                    precioUnitario.ToString("N2") +
                                    " = $" +
                                    subtotal.ToString("N2")
                                );

                                numeroProducto++;
                            }

                            if (!ventaEncontrada)
                            {
                                MessageBox.Show(
                                    "La venta no existe o no pertenece al cajero actual.",
                                    "Venta no encontrada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                                return;
                            }

                            MessageBox.Show(
                                detalle.ToString(),
                                "Detalle de venta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible consultar el detalle de la venta.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
        private void btnFiltrar_Click(
            object sender,
            EventArgs e)
        {
            CargarVentas();
        }

        private void btnLimpiarFiltros_Click(
            object sender,
            EventArgs e)
        {
            dtpFechaInicio.Value =
                DateTime.Today.AddDays(-30);

            dtpFechaFin.Value =
                DateTime.Today;

            if (cmbMetodoPagoFiltro.Items.Count > 0)
            {
                cmbMetodoPagoFiltro.SelectedIndex = 0;
            }

            if (cmbEstadoFiltro.Items.Count > 0)
            {
                cmbEstadoFiltro.SelectedIndex = 0;
            }

            CargarVentas();
        }


        private void btnPuntoVenta_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSesion())
            {
                return;
            }

            frmPuntodeVentaCajero formularioPuntoVenta =
                new frmPuntodeVentaCajero();

            formularioPuntoVenta.Show();

          
            Close();
        }


        private void btnCerrarSesion_Click(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Quieres cerrar sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

           
            SesionActual.CerrarSesion();

            
            MostrarLogin();
        }

        private void MostrarLogin()
        {
            login formularioLogin =
                Application.OpenForms
                    .OfType<login>()
                    .FirstOrDefault(
                        formulario =>
                            !formulario.IsDisposed
                    );

            if (formularioLogin == null)
            {
                formularioLogin = new login();
            }

            LimpiarControlesLogin(formularioLogin);

            formularioLogin.Show();

            formularioLogin.WindowState =
                FormWindowState.Normal;

            formularioLogin.BringToFront();
            formularioLogin.Activate();

            Close();
        }

        private void LimpiarControlesLogin(
            login formularioLogin)
        {
            TextBox campoUsuario =
                formularioLogin.Controls
                    .Find(
                        "txtUsuario",
                        true
                    )
                    .FirstOrDefault() as TextBox;

            TextBox campoContrasena =
                formularioLogin.Controls
                    .Find(
                        "txtContrasena",
                        true
                    )
                    .FirstOrDefault() as TextBox;

            CheckBox mostrarContrasena =
                formularioLogin.Controls
                    .Find(
                        "chkMostrarContrasena",
                        true
                    )
                    .FirstOrDefault() as CheckBox;

            campoUsuario?.Clear();
            campoContrasena?.Clear();

            if (mostrarContrasena != null)
            {
                mostrarContrasena.Checked = false;
            }

            campoUsuario?.Focus();
        }

        

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblPeriodoTicket_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}
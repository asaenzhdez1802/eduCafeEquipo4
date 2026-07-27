using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmMisVentasCajero : Form
    {
        private readonly int idCajero;
        private readonly string nombreCajero;

        // Constructor necesario para abrir el diseñador.
        public frmMisVentasCajero()
            : this(0, "Cajero")
        {
        }

        // Constructor utilizado al abrir desde Punto de venta.
        public frmMisVentasCajero(int idUsuario, string nombreCompleto)
        {
            InitializeComponent();

            idCajero = idUsuario;
            nombreCajero = string.IsNullOrWhiteSpace(nombreCompleto)
                ? "Cajero"
                : nombreCompleto;

            Text = "Mis ventas - " + nombreCajero;

            ConfigurarFormulario();
            ConectarEventos();

            // Evita consultar MySQL cuando Visual Studio abre el diseñador.
            if (idCajero > 0)
            {
                CargarResumen();
                CargarVentas();
            }
        }

        private void ConfigurarFormulario()
        {
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpfechafin.Value = DateTime.Today;

            // La tabla venta actual no guarda el método de pago.
            // Por eso el filtro queda visible, pero deshabilitado.
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Todos");
            cmbMetodoPago.SelectedIndex = 0;
            cmbMetodoPago.Enabled = false;

            ConfigurarColumnas();
        }

        private void ConfigurarColumnas()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.MultiSelect = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVentas.Columns.Add("colFolio", "Folio");
            dgvVentas.Columns.Add("colFecha", "Fecha");
            dgvVentas.Columns.Add("colHora", "Hora");
            dgvVentas.Columns.Add("colProductos", "Productos");
            dgvVentas.Columns.Add("colTotal", "Total");
            dgvVentas.Columns.Add("colMetodoPago", "Método de pago");

            DataGridViewButtonColumn columnaAcciones =
                new DataGridViewButtonColumn();

            columnaAcciones.Name = "colAcciones";
            columnaAcciones.HeaderText = "Acciones";
            columnaAcciones.Text = "Ver";
            columnaAcciones.UseColumnTextForButtonValue = true;
            columnaAcciones.FlatStyle = FlatStyle.Flat;

            dgvVentas.Columns.Add(columnaAcciones);

            dgvVentas.Columns["colFolio"].FillWeight = 90;
            dgvVentas.Columns["colFecha"].FillWeight = 85;
            dgvVentas.Columns["colHora"].FillWeight = 75;
            dgvVentas.Columns["colProductos"].FillWeight = 70;
            dgvVentas.Columns["colTotal"].FillWeight = 75;
            dgvVentas.Columns["colMetodoPago"].FillWeight = 100;
            dgvVentas.Columns["colAcciones"].FillWeight = 60;
        }

        private void ConectarEventos()
        {
            btnPuntoVenta.Click -= btnPuntoVenta_Click;
            btnCerrarSesion.Click -= btnCerrarSesion_Click;
            btnFiltrar.Click -= btnFiltrar_Click;
            btnLimpiarFiltros.Click -= btnLimpiarFiltros_Click;
            dgvVentas.CellContentClick -= dgvVentas_CellContentClick;

            btnPuntoVenta.Click += btnPuntoVenta_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            btnFiltrar.Click += btnFiltrar_Click;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
        }

        private void CargarResumen()
        {
            try
            {
                DateTime hoy = DateTime.Today;
                DateTime finDia = hoy.AddDays(1);

                int diasDesdeLunes = ((int)hoy.DayOfWeek + 6) % 7;
                DateTime inicioSemana = hoy.AddDays(-diasDesdeLunes);
                DateTime finSemana = inicioSemana.AddDays(7);

                DateTime inicioMes = new DateTime(hoy.Year, hoy.Month, 1);
                DateTime finMes = inicioMes.AddMonths(1);

                using (MySqlConnection conexion =
                       new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string consulta = @"
                        SELECT
                            COALESCE(SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_dia
                                     AND fecha_hora < @fin_dia
                                    THEN total
                                    ELSE 0
                                END
                            ), 0) AS total_dia,

                            SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_dia
                                     AND fecha_hora < @fin_dia
                                    THEN 1
                                    ELSE 0
                                END
                            ) AS cantidad_dia,

                            COALESCE(SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_semana
                                     AND fecha_hora < @fin_semana
                                    THEN total
                                    ELSE 0
                                END
                            ), 0) AS total_semana,

                            SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_semana
                                     AND fecha_hora < @fin_semana
                                    THEN 1
                                    ELSE 0
                                END
                            ) AS cantidad_semana,

                            COALESCE(SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_mes
                                     AND fecha_hora < @fin_mes
                                    THEN total
                                    ELSE 0
                                END
                            ), 0) AS total_mes,

                            SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_mes
                                     AND fecha_hora < @fin_mes
                                    THEN 1
                                    ELSE 0
                                END
                            ) AS cantidad_mes,

                            COALESCE(AVG(
                                CASE
                                    WHEN fecha_hora >= @inicio_mes
                                     AND fecha_hora < @fin_mes
                                    THEN total
                                    ELSE NULL
                                END
                            ), 0) AS ticket_promedio
                        FROM venta
                        WHERE id_usuario = @id_usuario;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_usuario", idCajero);
                        comando.Parameters.AddWithValue("@inicio_dia", hoy);
                        comando.Parameters.AddWithValue("@fin_dia", finDia);
                        comando.Parameters.AddWithValue("@inicio_semana", inicioSemana);
                        comando.Parameters.AddWithValue("@fin_semana", finSemana);
                        comando.Parameters.AddWithValue("@inicio_mes", inicioMes);
                        comando.Parameters.AddWithValue("@fin_mes", finMes);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (!lector.Read())
                            {
                                return;
                            }

                            decimal totalDia = Convert.ToDecimal(lector["total_dia"]);
                            int cantidadDia = Convert.ToInt32(lector["cantidad_dia"]);

                            decimal totalSemana = Convert.ToDecimal(lector["total_semana"]);
                            int cantidadSemana = Convert.ToInt32(lector["cantidad_semana"]);

                            decimal totalMes = Convert.ToDecimal(lector["total_mes"]);
                            int cantidadMes = Convert.ToInt32(lector["cantidad_mes"]);

                            decimal ticketPromedio = Convert.ToDecimal(lector["ticket_promedio"]);

                            lblTituloVentasDia.Text = "$" + totalDia.ToString("N2");
                            lblCantidadVentasDia.Text = cantidadDia + " ventas";

                            lblVentasSemana.Text = "$" + totalSemana.ToString("N2");

                            lblCantidadVentasSemana.Text = cantidadSemana + " ventas";

                            lblVentasMes.Text = "$" + totalMes.ToString("N2");
                            lblCantidadVentasSemana.Text = cantidadMes + " ventas";

                            lblTicketPromedio.Text = "$" + ticketPromedio.ToString("N2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar el resumen de ventas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarVentas()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpfechafin.Value.Date;

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

            try
            {
                dgvVentas.Rows.Clear();

                using (MySqlConnection conexion =
                       new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string consulta = @"
                        SELECT
                            v.id_venta,
                            v.fecha_hora,
                            v.total,
                            COALESCE(SUM(dv.cantidad), 0) AS productos
                        FROM venta AS v
                        LEFT JOIN detalle_venta AS dv
                            ON dv.id_venta = v.id_venta
                        WHERE v.id_usuario = @id_usuario
                          AND v.fecha_hora >= @fecha_inicio
                          AND v.fecha_hora < @fecha_fin
                        GROUP BY
                            v.id_venta,
                            v.fecha_hora,
                            v.total
                        ORDER BY v.fecha_hora DESC;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_usuario", idCajero);
                        comando.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                        comando.Parameters.AddWithValue("@fecha_fin", fechaFin.AddDays(1));

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                int idVenta = Convert.ToInt32(lector["id_venta"]);
                                DateTime fechaHora = Convert.ToDateTime(lector["fecha_hora"]);
                                int cantidadProductos = Convert.ToInt32(lector["productos"]);
                                decimal total = Convert.ToDecimal(lector["total"]);

                                int indiceFila = dgvVentas.Rows.Add(
                                    "VTA-" + idVenta.ToString("D5"),
                                    fechaHora.ToString("dd/MM/yyyy"),
                                    fechaHora.ToString("hh:mm tt"),
                                    cantidadProductos,
                                    "$" + total.ToString("N2"),
                                    "No registrado",
                                    "Ver"
                                );

                                dgvVentas.Rows[indiceFila].Tag = idVenta;
                            }
                        }
                    }
                }

                dgvVentas.ClearSelection();
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

                    string consulta = @"
                        SELECT
                           p.nombre AS producto,  dv.cantidad,  dv.precio_unitario, dv.subtotal FROM detalle_venta AS dv INNER JOIN producto AS p ON p.id_producto = dv.id_producto WHERE dv.id_venta = @id_venta ORDER BY p.nombre ASC;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_venta", idVenta);

                        StringBuilder detalle = new StringBuilder();
                        decimal total = 0;

                        detalle.AppendLine("Venta: VTA-" + idVenta.ToString("D5"));
                        detalle.AppendLine();

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string producto = Convert.ToString(lector["producto"]);
                                int cantidad = Convert.ToInt32(lector["cantidad"]);
                                decimal precio = Convert.ToDecimal(lector["precio_unitario"]);
                                decimal subtotal = Convert.ToDecimal(lector["subtotal"]);

                                total += subtotal;

                                detalle.AppendLine(producto);
                                detalle.AppendLine(
                                    cantidad + " x $" + precio.ToString("N2") +
                                    " = $" + subtotal.ToString("N2")
                                );
                                detalle.AppendLine();
                            }
                        }

                        detalle.AppendLine("Total: $" + total.ToString("N2"));

                        MessageBox.Show(
                            detalle.ToString(),
                            "Detalle de venta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpfechafin.Value = DateTime.Today;
            cmbMetodoPago.SelectedIndex = 0;

            CargarVentas();
        }

        private void dgvVentas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvVentas.Columns[e.ColumnIndex].Name != "colAcciones")
            {
                return;
            }

            object valorId = dgvVentas.Rows[e.RowIndex].Tag;

            if (valorId == null)
            {
                return;
            }

            MostrarDetalleVenta(Convert.ToInt32(valorId));
        }

        private void btnPuntoVenta_Click(object sender, EventArgs e)
        {
            frmPuntodeVentaCajero formulario =
                new frmPuntodeVentaCajero(idCajero, nombreCajero);

            formulario.Show();
            Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas cerrar la sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            login formularioLogin = new login();
            formularioLogin.Show();
            Close();
        }

        // Eventos creados desde el diseñador. Se conservan para evitar errores.
        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
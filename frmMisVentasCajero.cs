using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmMisVentasCajero : Form
    {
        public frmMisVentasCajero()
        {
            InitializeComponent();

           
            this.Load += frmMisVentasCajero_Load;

           
            btnPuntoVenta.Click += btnPuntoVenta_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;

           
            btnFiltrar.Click += btnFiltrar_Click;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;

           
            btnMisVentas.Enabled = false;
        }

        private void frmMisVentasCajero_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarFiltros();
            CargarResumenVentas();
            CargarVentas();
        }

      

        private void ConfigurarFiltros()
        {
          
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpFechaFin.Value = DateTime.Today;

         

            cmbMetodoPagoFiltro.Items.Clear();
            cmbMetodoPagoFiltro.Items.Add("Todos");
            cmbMetodoPagoFiltro.SelectedIndex = 0;
            cmbMetodoPagoFiltro.Enabled = false;

            cmbEstadoFiltro.Items.Clear();
            cmbEstadoFiltro.Items.Add("Todos");
            cmbEstadoFiltro.SelectedIndex = 0;
            cmbEstadoFiltro.Enabled = false;

            dgvHistorialVentas.Rows.Clear();
            dgvHistorialVentas.ClearSelection();
        }

       

        private void CargarResumenVentas()
        {
            DateTime hoy = DateTime.Today;
            DateTime finDia = hoy.AddDays(1);

          
            int diasDesdeLunes =
                ((int)hoy.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;

            DateTime inicioSemana =
                hoy.AddDays(-diasDesdeLunes);

            DateTime finSemana =
                inicioSemana.AddDays(7);

            DateTime inicioMes =
                new DateTime(hoy.Year, hoy.Month, 1);

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
                                        WHEN fecha_hora >= @inicio_dia
                                         AND fecha_hora < @fin_dia
                                        THEN total
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS monto_dia,

                            SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_dia
                                     AND fecha_hora < @fin_dia
                                    THEN 1
                                    ELSE 0
                                END
                            ) AS cantidad_dia,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicio_semana
                                         AND fecha_hora < @fin_semana
                                        THEN total
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS monto_semana,

                            SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_semana
                                     AND fecha_hora < @fin_semana
                                    THEN 1
                                    ELSE 0
                                END
                            ) AS cantidad_semana,

                            COALESCE(
                                SUM(
                                    CASE
                                        WHEN fecha_hora >= @inicio_mes
                                         AND fecha_hora < @fin_mes
                                        THEN total
                                        ELSE 0
                                    END
                                ),
                                0
                            ) AS monto_mes,

                            SUM(
                                CASE
                                    WHEN fecha_hora >= @inicio_mes
                                     AND fecha_hora < @fin_mes
                                    THEN 1
                                    ELSE 0
                                END
                            ) AS cantidad_mes
                        FROM venta;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@inicio_dia",
                            hoy
                        );

                        comando.Parameters.AddWithValue(
                            "@fin_dia",
                            finDia
                        );

                        comando.Parameters.AddWithValue(
                            "@inicio_semana",
                            inicioSemana
                        );

                        comando.Parameters.AddWithValue(
                            "@fin_semana",
                            finSemana
                        );

                        comando.Parameters.AddWithValue(
                            "@inicio_mes",
                            inicioMes
                        );

                        comando.Parameters.AddWithValue(
                            "@fin_mes",
                            finMes
                        );

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
                                FormatearCantidadVentas(cantidadDia);

                            lblMontoSemana.Text =
                                "$ " + montoSemana.ToString("N2");

                            lblCantidadSemana.Text =
                                FormatearCantidadVentas(cantidadSemana);

                            lblMontoMes.Text =
                                "$ " + montoMes.ToString("N2");

                            lblCantidadMes.Text =
                                FormatearCantidadVentas(cantidadMes);

                            lblMontoTicket.Text =
                                "$ " + ticketPromedio.ToString("N2");

                            lblPeriodoTicket.Text = "Este mes";
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

        private string FormatearCantidadVentas(int cantidad)
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
            DateTime fechaInicio =
                dtpFechaInicio.Value.Date;

            DateTime fechaFin =
                dtpFechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show(
                    "La fecha de inicio no puede ser mayor " +
                    "que la fecha final.",
                    "Fechas incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

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

                    string consulta = @"
                        SELECT
                            v.id_venta,
                            v.fecha_hora,
                            v.total,
                            COALESCE(
                                SUM(dv.cantidad),
                                0
                            ) AS cantidad_productos
                        FROM venta AS v

                        LEFT JOIN detalle_venta AS dv
                            ON dv.id_venta = v.id_venta

                        WHERE v.fecha_hora >= @fecha_inicio
                          AND v.fecha_hora < @fecha_fin

                        GROUP BY
                            v.id_venta,
                            v.fecha_hora,
                            v.total

                        ORDER BY
                            v.fecha_hora DESC;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@fecha_inicio",
                            fechaInicio
                        );


                        comando.Parameters.AddWithValue(
                            "@fecha_fin",
                            fechaFin.AddDays(1)
                        );

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
                                        lector["cantidad_productos"]
                                    );

                                decimal total =
                                    Convert.ToDecimal(
                                        lector["total"]
                                    );

                                int indiceFila =
                                    dgvHistorialVentas.Rows.Add(
                                        "VTA-" +
                                        idVenta.ToString("D5"),

                                        fechaHora.ToString(
                                            "dd/MM/yyyy"
                                        ),

                                        fechaHora.ToString(
                                            "hh:mm tt"
                                        ),

                                        cantidadProductos,

                                        "$ " +
                                        total.ToString("N2"),

                                        "No registrado",

                                        "Ver"
                                    );

                              
                                dgvHistorialVentas
                                    .Rows[indiceFila]
                                    .Tag = idVenta;
                            }
                        }
                    }
                }

                dgvHistorialVentas.ClearSelection();

                lblNotaHistorial.Text =
                    "ⓘ Se encontraron " +
                    dgvHistorialVentas.Rows.Count +
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
            frmPuntodeVentaCajero formularioPuntoVenta =
                new frmPuntodeVentaCajero();

            formularioPuntoVenta.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿En realidad quieres cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            login formularioLogin = BuscarLoginAbierto();

            if (formularioLogin == null ||
                formularioLogin.IsDisposed)
            {
                formularioLogin = new login();
            }

            formularioLogin.Show();
            formularioLogin.BringToFront();
            formularioLogin.Activate();

            this.Close();
        }

        private login BuscarLoginAbierto()
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario is login loginAbierto)
                {
                    return loginAbierto;
                }
            }

            return null;
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
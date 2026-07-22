using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFechaFinal.Value = DateTime.Now;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) { }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Opcional: cargar reporte del mes actual al abrir
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Conexion conClase = new Conexion();

            try
            {
                using (MySqlConnection conexion = conClase.GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo conectar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();

                    DateTime fechaInicio = dtpFechaInicio.Value.Date;
                    DateTime fechaFinal = dtpFechaFinal.Value.Date.AddDays(1).AddTicks(-1);

                    // Detalle del reporte por día
                    string queryDetalle = @"
                SELECT 
                    DATE(v.fecha_hora) AS fecha,
                    COUNT(DISTINCT v.id_venta) AS numero_ventas,
                    SUM(dv.cantidad) AS productos_vendidos,
                    SUM(v.total) AS total_ventas
                FROM venta v
                INNER JOIN detalle_venta dv ON v.id_venta = dv.id_venta
                WHERE v.fecha_hora BETWEEN @fechaInicio AND @fechaFinal
                GROUP BY DATE(v.fecha_hora)
                ORDER BY fecha ASC";

                    using (MySqlCommand cmd = new MySqlCommand(queryDetalle, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvReporte.Rows.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                dgvReporte.Rows.Add(
                                    Convert.ToDateTime(row["fecha"]).ToString("dd/MM/yyyy"),
                                    row["numero_ventas"].ToString(),
                                    row["productos_vendidos"].ToString(),
                                    "$ " + Convert.ToDecimal(row["total_ventas"]).ToString("F2"),
                                    "N/A" // No hay metodo_pago en la BD
                                );
                            }
                        }
                    }

                    // Estadísticas generales
                    string queryStats = @"
                SELECT 
                    COUNT(DISTINCT v.id_venta) AS total_ventas,
                    SUM(dv.cantidad) AS total_productos,
                    SUM(v.total) AS total_monto
                FROM venta v
                INNER JOIN detalle_venta dv ON v.id_venta = dv.id_venta
                WHERE v.fecha_hora BETWEEN @fechaInicio AND @fechaFinal";

                    using (MySqlCommand cmdStats = new MySqlCommand(queryStats, conexion))
                    {
                        cmdStats.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmdStats.Parameters.AddWithValue("@fechaFinal", fechaFinal);

                        using (MySqlDataReader lector = cmdStats.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int numVentas = Convert.ToInt32(lector["total_ventas"]);
                                int totalProductos = lector["total_productos"] == DBNull.Value ? 0 : Convert.ToInt32(lector["total_productos"]);
                                decimal totalMonto = lector["total_monto"] == DBNull.Value ? 0 : Convert.ToDecimal(lector["total_monto"]);

                                lblCantidadNumeroVentas.Text = numVentas.ToString();
                                lblCantidadProductosVendidos.Text = totalProductos.ToString();
                                lblCantidadVentasTotales.Text = "$ " + totalMonto.ToString("F2");

                                decimal ticketPromedio = numVentas > 0 ? totalMonto / numVentas : 0;
                                lblCantidadTicketPromedio.Text = "$ " + ticketPromedio.ToString("F2");

                                lblDescripcionVentasTotales.Text = $"{fechaInicio:dd/MM/yyyy} - {dtpFechaFinal.Value.Date:dd/MM/yyyy}";
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashAdmin frm = new frmDashAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventarioAdmin frm = new frmInventarioAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedoresAdmin frm = new frmProveedoresAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿En realidad quiere cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login frm = new login();
                frm.Show();
                this.Hide();
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaAdmin frm = new frmCategoriaAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductosAdmin frm = new frmProductosAdmin();

            frm.Show();
            this.Hide();
        }
    }
}
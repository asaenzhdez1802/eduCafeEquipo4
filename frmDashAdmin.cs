using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmDashAdmin : Form
    {
        //=========================
        // VARIABLES GLOBALES
        //=========================
        Conexion conexion = new Conexion();
        MySqlConnection con;

        public frmDashAdmin()
        {
            InitializeComponent();

            // Mapeo de columnas para el DataGridView
            dgvBajoStock.AutoGenerateColumns = false;
            colProducto.DataPropertyName = "Producto";
            colCategoria.DataPropertyName = "Categoria";
            colStockActual.DataPropertyName = "StockActual";
            colStockMinimo.DataPropertyName = "StockMinimo";
            colEstado.DataPropertyName = "Estado";

            CargarDashboard();
        }

        //=========================
        // CARGAR DASHBOARD
        //=========================
        private void CargarDashboard()
        {
            CargarTotalProductos();
            CargarVentasHoy();
            CargarProductosBajoStock();
            CargarProductosAgotados();
            CargarGridBajoStock();
        }

        //=========================
        // TOTAL PRODUCTOS
        //=========================
        private void CargarTotalProductos()
        {
            try
            {
                con = conexion.GetConexion();
                string sql = @"SELECT COUNT(*)
                               FROM producto
                               WHERE estado='Activo'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                lblCantidadProductos.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar total de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //=========================
        // VENTAS DEL DIA
        //=========================
        private void CargarVentasHoy()
        {
            try
            {
                con = conexion.GetConexion();
                string sql = @"SELECT IFNULL(SUM(total),0)
                               FROM venta
                               WHERE DATE(fecha_hora)=CURDATE();";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                lblCantidadVentas.Text = "$ " + total.ToString("N2");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas de hoy: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //=========================
        // PRODUCTOS BAJO STOCK
        //=========================
        private void CargarProductosBajoStock()
        {
            try
            {
                con = conexion.GetConexion();
                string sql = @"SELECT COUNT(*)
                               FROM inventario
                               WHERE existencia_actual <= stock_minimo
                               AND existencia_actual > 0;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                lblCantidadInventario.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos con bajo stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //=========================
        // PRODUCTOS AGOTADOS
        //=========================
        private void CargarProductosAgotados()
        {
            try
            {
                con = conexion.GetConexion();
                string sql = @"SELECT COUNT(*)
                               FROM inventario
                               WHERE existencia_actual = 0;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                lblCantidadAgotados.Text = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos agotados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //=========================
        // GRID DE PRODUCTOS CON BAJO STOCK
        //=========================
        private void CargarGridBajoStock()
        {
            try
            {
                con = conexion.GetConexion();

                string sql = @"
                    SELECT
                        p.nombre AS Producto,
                        c.nombre AS Categoria,
                        i.existencia_actual AS StockActual,
                        i.stock_minimo AS StockMinimo,
                        CASE
                            WHEN i.existencia_actual = 0 THEN 'AGOTADO'
                            WHEN i.existencia_actual <= i.stock_minimo THEN 'BAJO STOCK'
                            ELSE 'DISPONIBLE'
                        END AS Estado
                    FROM producto p
                    INNER JOIN categoria c ON p.id_categoria = c.id_categoria
                    INNER JOIN inventario i ON p.id_producto = i.id_producto
                    WHERE i.existencia_actual <= i.stock_minimo
                    ORDER BY i.existencia_actual ASC;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBajoStock.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de bajo stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        //=========================
        // EVENTOS DE NAVEGACIÓN
        //=========================

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Recarga las métricas del dashboard si se vuelve a dar clic en Inicio
            CargarDashboard();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frmProductosAdmin frm = new frmProductosAdmin();
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

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaAdmin frm = new frmCategoriaAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿En realidad quiere cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login frm = new login();
                frm.Show();
                this.Hide();
            }
        }
    }
}
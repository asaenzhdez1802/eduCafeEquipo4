using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmProductosAdmin : Form
    {
        private int idProductoSeleccionado = 0;

        public frmProductosAdmin()
        {
            InitializeComponent();
            this.Load += frmProductosAdmin_Load;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            cmbBuscarCategoria.SelectedIndexChanged += cmbBuscarCategoria_SelectedIndexChanged;
            dgvProductos.CellClick += dgvProductos_CellClick;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void frmProductosAdmin_Load(object sender, EventArgs e)
        {
            ConfigurarEstado();
            CargarCategoriasFiltro();
            CargarCategoriasFormulario();
            CargarProductos();
            LimpiarCampos();
        }

        private void ConfigurarEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = -1;
        }

        private void CargarCategoriasFiltro()
        {
            Conexion conClase = new Conexion();
            try
            {
                using (MySqlConnection conexion = conClase.GetConexion())
                {
                    string query = "SELECT id_categoria, nombre FROM categoria WHERE estado = 'Activo' ORDER BY nombre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        DataRow fila = dt.NewRow();
                        fila["id_categoria"] = 0;
                        fila["nombre"] = "Todas";
                        dt.Rows.InsertAt(fila, 0);

                        cmbBuscarCategoria.DisplayMember = "nombre";
                        cmbBuscarCategoria.ValueMember = "id_categoria";
                        cmbBuscarCategoria.DataSource = dt;
                        cmbBuscarCategoria.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategoriasFormulario()
        {
            Conexion conClase = new Conexion();
            try
            {
                using (MySqlConnection conexion = conClase.GetConexion())
                {
                    string query = "SELECT id_categoria, nombre FROM categoria WHERE estado = 'Activo' ORDER BY nombre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCategoria.DisplayMember = "nombre";
                        cmbCategoria.ValueMember = "id_categoria";
                        cmbCategoria.DataSource = dt;
                        cmbCategoria.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos(string nombre = "", int idCategoria = 0)
        {
            Conexion conClase = new Conexion();
            try
            {
                using (MySqlConnection conexion = conClase.GetConexion())
                {
                    string query = @"
                        SELECT 
                            p.id_producto,
                            p.nombre,
                            c.nombre AS categoria,
                            p.precio_compra,
                            p.precio_venta,
                            COALESCE(i.stock_minimo, 0) AS stock_minimo,
                            p.estado
                        FROM producto p
                        INNER JOIN categoria c ON p.id_categoria = c.id_categoria
                        LEFT JOIN inventario i ON p.id_producto = i.id_producto
                        WHERE (@nombre = '' OR p.nombre LIKE @busqueda)
                          AND (@idCategoria = 0 OR p.id_categoria = @idCategoria)
                        ORDER BY p.nombre ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@busqueda", "%" + nombre + "%");
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvProductos.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            int idCat = cmbBuscarCategoria.SelectedValue != null ? Convert.ToInt32(cmbBuscarCategoria.SelectedValue) : 0;
            CargarProductos(txtBuscarProducto.Text.Trim(), idCat);
        }

        private void cmbBuscarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCat = cmbBuscarCategoria.SelectedValue != null ? Convert.ToInt32(cmbBuscarCategoria.SelectedValue) : 0;
            CargarProductos(txtBuscarProducto.Text.Trim(), idCat);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            idProductoSeleccionado = Convert.ToInt32(fila.Cells["id_producto"].Value);
            CargarDatosProducto(idProductoSeleccionado);
        }

        private void CargarDatosProducto(int idProducto)
        {
            Conexion conClase = new Conexion();
            try
            {
                using (MySqlConnection conexion = conClase.GetConexion())
                {
                    string query = @"
                        SELECT 
                            p.id_producto,
                            p.nombre,
                            p.id_categoria,
                            p.precio_compra,
                            p.precio_venta,
                            p.estado,
                            COALESCE(i.stock_minimo, 0) AS stock_minimo
                        FROM producto p
                        LEFT JOIN inventario i ON p.id_producto = i.id_producto
                        WHERE p.id_producto = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        using (MySqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtCodigo.Text = lector["id_producto"].ToString();
                                txtNombreProducto.Text = lector["nombre"].ToString();
                                txtPrecioCompra.Text = lector["precio_compra"].ToString();
                                txtPrecioVenta.Text = lector["precio_venta"].ToString();
                                txtStockMinimo.Text = lector["stock_minimo"].ToString();
                                cmbEstado.SelectedItem = lector["estado"].ToString();

                                int idCat = Convert.ToInt32(lector["id_categoria"]);
                                foreach (DataRowView item in cmbCategoria.Items)
                                {
                                    if (Convert.ToInt32(item["id_categoria"]) == idCat)
                                    {
                                        cmbCategoria.SelectedItem = item;
                                        break;
                                    }
                                }

                                btnGuardar.Text = "Actualizar";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombreProducto.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingresa el nombre del producto.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una categoría.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text.Trim(), out _))
            {
                MessageBox.Show("Ingresa un precio de compra válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out _))
            {
                MessageBox.Show("Ingresa un precio de venta válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            if (!int.TryParse(txtStockMinimo.Text.Trim(), out _))
            {
                MessageBox.Show("Ingresa un stock mínimo válido (número entero).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockMinimo.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona el estado del producto.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Conexion conClase = new Conexion();
            MySqlConnection conexion = conClase.GetConexion();
            if (conexion == null) return;

            try
            {
                int idCategoria = Convert.ToInt32(((DataRowView)cmbCategoria.SelectedItem)["id_categoria"]);
                string nombre = txtNombreProducto.Text.Trim();
                decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text.Trim());
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                int stockMinimo = Convert.ToInt32(txtStockMinimo.Text.Trim());
                string estado = cmbEstado.SelectedItem.ToString();

                if (btnGuardar.Text == "Guardar")
                {
                    string sqlProducto = @"
                        INSERT INTO producto (id_categoria, nombre, precio_compra, precio_venta, estado)
                        VALUES (@id_categoria, @nombre, @precio_compra, @precio_venta, @estado)";

                    MySqlCommand cmd = new MySqlCommand(sqlProducto, conexion);
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio_compra", precioCompra);
                    cmd.Parameters.AddWithValue("@precio_venta", precioVenta);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();

                    long nuevoId = cmd.LastInsertedId;

                    string sqlInventario = @"
                        INSERT INTO inventario (id_producto, existencia_actual, stock_minimo, fecha_actualizacion)
                        VALUES (@id_producto, 0, @stock_minimo, NOW())";

                    MySqlCommand cmdInv = new MySqlCommand(sqlInventario, conexion);
                    cmdInv.Parameters.AddWithValue("@id_producto", nuevoId);
                    cmdInv.Parameters.AddWithValue("@stock_minimo", stockMinimo);
                    cmdInv.ExecuteNonQuery();

                    conexion.Close();
                    MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btnGuardar.Text == "Actualizar")
                {
                    string sqlUpdate = @"
                        UPDATE producto 
                        SET id_categoria = @id_categoria, nombre = @nombre,
                            precio_compra = @precio_compra, precio_venta = @precio_venta, estado = @estado
                        WHERE id_producto = @id_producto";

                    MySqlCommand cmd = new MySqlCommand(sqlUpdate, conexion);
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio_compra", precioCompra);
                    cmd.Parameters.AddWithValue("@precio_venta", precioVenta);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id_producto", idProductoSeleccionado);
                    cmd.ExecuteNonQuery();

                    string sqlInvUpdate = @"
                        UPDATE inventario SET stock_minimo = @stock_minimo
                        WHERE id_producto = @id_producto";

                    MySqlCommand cmdInv = new MySqlCommand(sqlInvUpdate, conexion);
                    cmdInv.Parameters.AddWithValue("@stock_minimo", stockMinimo);
                    cmdInv.Parameters.AddWithValue("@id_producto", idProductoSeleccionado);
                    cmdInv.ExecuteNonQuery();

                    conexion.Close();
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarProductos(txtBuscarProducto.Text.Trim());
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idProductoSeleccionado = 0;
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStockMinimo.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            btnGuardar.Text = "Guardar";
            dgvProductos.ClearSelection();
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
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
    }
}
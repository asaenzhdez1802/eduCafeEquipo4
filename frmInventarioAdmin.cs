using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eduCafeEquipo4
{
    public partial class frmInventarioAdmin : Form
    {
        // Variables globales para la selección
        private int idProductoSeleccionado = 0;
        private int existenciaSeleccionada = 0;
        private string estadoProductoSeleccionado = "";

        // Banderas de control
        private bool cargandoDatos = false;

        public frmInventarioAdmin()
        {
            InitializeComponent();

            ConfigurarFormulario();

            // DESVINCULACIÓN PREVIA: Evita que el evento se dispare 2 veces seguidas por clic
            this.Load -= frmInventarioAdmin_Load;
            this.Load += frmInventarioAdmin_Load;

            txtBuscarProducto.TextChanged -= txtBuscarProducto_TextChanged;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;

            cmbBuscarCategoria.SelectedIndexChanged -= cmbBuscarCategoria_SelectedIndexChanged;
            cmbBuscarCategoria.SelectedIndexChanged += cmbBuscarCategoria_SelectedIndexChanged;

            dgvInventario.CellClick -= dgvInventario_CellClick;
            dgvInventario.CellClick += dgvInventario_CellClick;

            btnRegistrar.Click -= btnRegistrar_Click;
            btnRegistrar.Click += btnRegistrar_Click;
        }

        #region Configuración e Inicialización

        private void ConfigurarFormulario()
        {
            cmbTipoMovimiento.Items.Clear();
            cmbTipoMovimiento.Items.Add("Entrada");
            cmbTipoMovimiento.Items.Add("Salida");
            cmbTipoMovimiento.SelectedIndex = -1;

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 100000;
            nudCantidad.Value = 1;

            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            txtProducto.ReadOnly = true;
        }

        private void frmInventarioAdmin_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarInventario();
            LimpiarMovimiento();
        }

        private MySqlConnection ObtenerConexion()
        {
            Conexion objetoConexion = new Conexion();
            MySqlConnection conexion = objetoConexion.GetConexion();

            if (conexion == null)
            {
                throw new Exception("No fue posible establecer conexión con la base de datos.");
            }

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            return conexion;
        }

        #endregion

        #region Carga de Datos y Filtros

        private void CargarCategorias()
        {
            try
            {
                cargandoDatos = true;

                using (MySqlConnection conexion = ObtenerConexion())
                {
                    string consulta = @"SELECT id_categoria, nombre FROM categoria ORDER BY nombre ASC;";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion))
                    {
                        DataTable tablaCategorias = new DataTable();
                        adaptador.Fill(tablaCategorias);

                        DataRow filaTodas = tablaCategorias.NewRow();
                        filaTodas["id_categoria"] = 0;
                        filaTodas["nombre"] = "Todas";
                        tablaCategorias.Rows.InsertAt(filaTodas, 0);

                        cmbBuscarCategoria.DisplayMember = "nombre";
                        cmbBuscarCategoria.ValueMember = "id_categoria";
                        cmbBuscarCategoria.DataSource = tablaCategorias;
                        cmbBuscarCategoria.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible cargar las categorías.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cargandoDatos = false;
            }
        }

        private void CargarInventario()
        {
            try
            {
                cargandoDatos = true;

                dgvInventario.Rows.Clear();

                int idCategoria = ObtenerCategoriaSeleccionada();
                string nombreProducto = txtBuscarProducto.Text.Trim();

                using (MySqlConnection conexion = ObtenerConexion())
                {
                    string consulta = @"
                        SELECT
                            p.id_producto,
                            p.nombre AS producto,
                            c.nombre AS categoria,
                            COALESCE(i.existencia_actual, 0) AS existencia_actual,
                            COALESCE(i.stock_minimo, 0) AS stock_minimo,
                            p.estado
                        FROM producto AS p
                        INNER JOIN categoria AS c
                            ON c.id_categoria = p.id_categoria
                        LEFT JOIN inventario AS i
                            ON i.id_producto = p.id_producto
                        WHERE
                            (
                                @nombre_producto = ''
                                OR p.nombre LIKE @busqueda
                            )
                            AND
                            (
                                @id_categoria = 0
                                OR p.id_categoria = @id_categoria
                            )
                        ORDER BY p.nombre ASC;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre_producto", nombreProducto);
                        comando.Parameters.AddWithValue("@busqueda", "%" + nombreProducto + "%");
                        comando.Parameters.AddWithValue("@id_categoria", idCategoria);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                dgvInventario.Rows.Add(
                                    lector["id_producto"].ToString(),
                                    lector["producto"].ToString(),
                                    lector["categoria"].ToString(),
                                    lector["existencia_actual"].ToString(),
                                    lector["stock_minimo"].ToString(),
                                    lector["estado"].ToString()
                                );
                            }
                        }
                    }
                }

                dgvInventario.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible cargar el inventario.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cargandoDatos = false;
            }
        }

        private int ObtenerCategoriaSeleccionada()
        {
            if (cmbBuscarCategoria.SelectedValue == null)
                return 0;

            if (int.TryParse(cmbBuscarCategoria.SelectedValue.ToString(), out int idCategoria))
            {
                return idCategoria;
            }

            return 0;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarInventario();
            LimpiarSeleccionProducto();
        }

        private void cmbBuscarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoDatos) return;
            CargarInventario();
            LimpiarSeleccionProducto();
        }

        #endregion

        #region Selección y Registro de Movimientos

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cargandoDatos || e.RowIndex < 0) return;

            DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];
            object valorId = fila.Cells["colCodigo"].Value;

            if (valorId == null || !int.TryParse(valorId.ToString(), out idProductoSeleccionado))
            {
                LimpiarSeleccionProducto();
                return;
            }

            // Llena la información en el panel de registro automáticamente
            txtProducto.Text = fila.Cells["colProducto"].Value?.ToString() ?? "";
            int.TryParse(fila.Cells["colExistencia"].Value?.ToString(), out existenciaSeleccionada);
            estadoProductoSeleccionado = fila.Cells["colEstado"].Value?.ToString() ?? "";
        }

        private void LimpiarSeleccionProducto()
        {
            idProductoSeleccionado = 0;
            existenciaSeleccionada = 0;
            estadoProductoSeleccionado = "";
            txtProducto.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarMovimiento()) return;

            string tipoMovimiento = cmbTipoMovimiento.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            DateTime fechaHora = dtpFecha.Value.Date.Add(dtpHora.Value.TimeOfDay);

            DialogResult respuesta = MessageBox.Show(
                $"Producto: {txtProducto.Text}\n" +
                $"Movimiento: {tipoMovimiento}\n" +
                $"Cantidad: {cantidad}\n\n" +
                "¿Deseas registrar este movimiento?",
                "Confirmar movimiento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes) return;

            try
            {
                RegistrarMovimiento(idProductoSeleccionado, tipoMovimiento, cantidad, fechaHora);

                MessageBox.Show("Movimiento registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar inventario y limpiar campos
                CargarInventario();
                LimpiarMovimiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible registrar el movimiento.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarMovimiento()
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un producto de la tabla.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (estadoProductoSeleccionado != "Activo")
            {
                MessageBox.Show("No se pueden registrar movimientos para un producto inactivo.", "Producto inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudCantidad.Focus();
                return false;
            }

            if (cmbTipoMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona el tipo de movimiento.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoMovimiento.Focus();
                return false;
            }

            if (cmbTipoMovimiento.SelectedItem.ToString() == "Salida")
            {
                int cantidad = Convert.ToInt32(nudCantidad.Value);
                if (cantidad > existenciaSeleccionada)
                {
                    MessageBox.Show($"No hay suficientes existencias.\n\nExistencia disponible: {existenciaSeleccionada}", "Existencia insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void RegistrarMovimiento(int idProducto, string tipoMovimiento, int cantidad, DateTime fechaHora)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                using (MySqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int existenciaActual;
                        string estadoActual;

                        string consultaExistencia = @"
                            SELECT i.existencia_actual, p.estado
                            FROM inventario AS i
                            INNER JOIN producto AS p ON p.id_producto = i.id_producto
                            WHERE i.id_producto = @id_producto
                            FOR UPDATE;";

                        using (MySqlCommand comandoExistencia = new MySqlCommand(consultaExistencia, conexion, transaccion))
                        {
                            comandoExistencia.Parameters.AddWithValue("@id_producto", idProducto);

                            using (MySqlDataReader lector = comandoExistencia.ExecuteReader())
                            {
                                if (!lector.Read())
                                {
                                    throw new Exception("El producto no tiene un registro de inventario.");
                                }

                                existenciaActual = Convert.ToInt32(lector["existencia_actual"]);
                                estadoActual = lector["estado"].ToString();
                            }
                        }

                        if (estadoActual != "Activo")
                        {
                            throw new Exception("El producto se encuentra inactivo.");
                        }

                        int nuevaExistencia;
                        if (tipoMovimiento == "Entrada")
                        {
                            nuevaExistencia = existenciaActual + cantidad;
                        }
                        else
                        {
                            if (cantidad > existenciaActual)
                            {
                                throw new Exception($"No hay suficientes existencias.\nExistencia disponible: {existenciaActual}");
                            }
                            nuevaExistencia = existenciaActual - cantidad;
                        }

                        string actualizarInventario = @"
                            UPDATE inventario
                            SET existencia_actual = @nueva_existencia,
                                fecha_actualizacion = @fecha_hora
                            WHERE id_producto = @id_producto;";

                        using (MySqlCommand comandoActualizar = new MySqlCommand(actualizarInventario, conexion, transaccion))
                        {
                            comandoActualizar.Parameters.AddWithValue("@nueva_existencia", nuevaExistencia);
                            comandoActualizar.Parameters.AddWithValue("@fecha_hora", fechaHora);
                            comandoActualizar.Parameters.AddWithValue("@id_producto", idProducto);

                            if (comandoActualizar.ExecuteNonQuery() == 0)
                            {
                                throw new Exception("No fue posible actualizar el inventario.");
                            }
                        }

                        string insertarMovimiento = @"
                            INSERT INTO movimiento_inventario (id_producto, tipo_movimiento, fecha_hora, cantidad)
                            VALUES (@id_producto, @tipo_movimiento, @fecha_hora, @cantidad);";

                        using (MySqlCommand comandoMovimiento = new MySqlCommand(insertarMovimiento, conexion, transaccion))
                        {
                            comandoMovimiento.Parameters.AddWithValue("@id_producto", idProducto);
                            comandoMovimiento.Parameters.AddWithValue("@tipo_movimiento", tipoMovimiento);
                            comandoMovimiento.Parameters.AddWithValue("@fecha_hora", fechaHora);
                            comandoMovimiento.Parameters.AddWithValue("@cantidad", cantidad);
                            comandoMovimiento.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        private void LimpiarMovimiento()
        {
            LimpiarSeleccionProducto();

            nudCantidad.Value = 1;
            cmbTipoMovimiento.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            dgvInventario.ClearSelection();
        }

        #endregion

        #region Navegación entre Formularios

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            frmDashAdmin frm = new frmDashAdmin();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frmProductosAdmin frm = new frmProductosAdmin();
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
            DialogResult respuesta = MessageBox.Show(
                "¿En realidad quiere cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                login frm = new login();
                frm.Show();
                this.Hide();
            }
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace eduCafeEquipo4
{
    public partial class frmInventarioAdmin : Form
    {
        private int idProductoSeleccionado = 0;
        private int existenciaSeleccionada = 0;
        private string estadoProductoSeleccionado = "";

        private bool cargandoCategorias = false;

        public frmInventarioAdmin()
        {
            InitializeComponent();

            ConfigurarFormulario();

            this.Load += frmInventarioAdmin_Load;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            cmbBuscarCategoria.SelectedIndexChanged += cmbBuscarCategoria_SelectedIndexChanged;
            dgvInventario.CellClick += dgvInventario_CellClick;
            btnRegistrar.Click += btnRegistrar_Click;
        }

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

        private void CargarCategorias()
        {
            try
            {
                cargandoCategorias = true;

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
                cargandoCategorias = false;
            }
        }

        private void CargarInventario()
        {
            try
            {
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

                        comando.Parameters.AddWithValue(
                            "@busqueda",
                            "%" + nombreProducto + "%"
                        );

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
                LimpiarSeleccionProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar el inventario.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private int ObtenerCategoriaSeleccionada()
        {
            if (cmbBuscarCategoria.SelectedValue == null)
            {
                return 0;
            }

            int idCategoria;

            bool conversionCorrecta = int.TryParse(
                cmbBuscarCategoria.SelectedValue.ToString(),
                out idCategoria
            );

            if (!conversionCorrecta)
            {
                return 0;
            }

            return idCategoria;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void cmbBuscarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCategorias)
            {
                return;
            }

            CargarInventario();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

            object valorId = fila.Cells["colCodigo"].Value;

            if (valorId == null)
            {
                return;
            }

            bool idCorrecto = int.TryParse(valorId.ToString(), out idProductoSeleccionado);

            if (!idCorrecto)
            {
                LimpiarSeleccionProducto();
                return;
            }

            txtProducto.Text =
                fila.Cells["colProducto"].Value?.ToString() ?? "";

            int.TryParse(
                fila.Cells["colExistencia"].Value?.ToString(),
                out existenciaSeleccionada
            );

            estadoProductoSeleccionado =
                fila.Cells["colEstado"].Value?.ToString() ?? "";
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
            if (!ValidarMovimiento())
            {
                return;
            }

            string tipoMovimiento = cmbTipoMovimiento.SelectedItem.ToString();

            int cantidad = Convert.ToInt32(nudCantidad.Value);

            DateTime fechaHora = dtpFecha.Value.Date.Add(
                dtpHora.Value.TimeOfDay
            );

            DialogResult respuesta = MessageBox.Show(
                "Producto: " + txtProducto.Text + "\n" +
                "Movimiento: " + tipoMovimiento + "\n" +
                "Cantidad: " + cantidad + "\n\n" +
                "¿Deseas registrar este movimiento?",
                "Confirmar movimiento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                RegistrarMovimiento(
                    idProductoSeleccionado,
                    tipoMovimiento,
                    cantidad,
                    fechaHora
                );

                MessageBox.Show(
                    "Movimiento registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarInventario();
                LimpiarMovimiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible registrar el movimiento.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidarMovimiento()
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Selecciona un producto de la tabla.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            if (estadoProductoSeleccionado != "Activo")
            {
                MessageBox.Show(
                    "No se pueden registrar movimientos para un producto inactivo.",
                    "Producto inactivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Cantidad incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudCantidad.Focus();
                return false;
            }

            if (cmbTipoMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona el tipo de movimiento.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbTipoMovimiento.Focus();
                return false;
            }

            if (cmbTipoMovimiento.SelectedItem.ToString() == "Salida")
            {
                int cantidad = Convert.ToInt32(nudCantidad.Value);

                if (cantidad > existenciaSeleccionada)
                {
                    MessageBox.Show(
                        "No hay suficientes existencias.\n\n" +
                        "Existencia disponible: " + existenciaSeleccionada,
                        "Existencia insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }
            }

            return true;
        }

        private void RegistrarMovimiento(
            int idProducto,
            string tipoMovimiento,
            int cantidad,
            DateTime fechaHora)
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
                            SELECT
                                i.existencia_actual,
                                p.estado
                            FROM inventario AS i
                            INNER JOIN producto AS p
                                ON p.id_producto = i.id_producto
                            WHERE i.id_producto = @id_producto
                            FOR UPDATE;";

                        using (MySqlCommand comandoExistencia = new MySqlCommand(
                            consultaExistencia,
                            conexion,
                            transaccion))
                        {
                            comandoExistencia.Parameters.AddWithValue(
                                "@id_producto",
                                idProducto
                            );

                            using (MySqlDataReader lector = comandoExistencia.ExecuteReader())
                            {
                                if (!lector.Read())
                                {
                                    throw new Exception(
                                        "El producto no tiene un registro de inventario."
                                    );
                                }

                                existenciaActual = Convert.ToInt32(
                                    lector["existencia_actual"]
                                );

                                estadoActual = lector["estado"].ToString();
                            }
                        }

                        if (estadoActual != "Activo")
                        {
                            throw new Exception(
                                "El producto se encuentra inactivo."
                            );
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
                                throw new Exception(
                                    "No hay suficientes existencias.\n" +
                                    "Existencia disponible: " + existenciaActual
                                );
                            }

                            nuevaExistencia = existenciaActual - cantidad;
                        }

                        string actualizarInventario = @"
                            UPDATE inventario
                            SET
                                existencia_actual = @nueva_existencia,
                                fecha_actualizacion = @fecha_hora
                            WHERE id_producto = @id_producto;";

                        using (MySqlCommand comandoActualizar = new MySqlCommand(actualizarInventario, conexion, transaccion))
                        {
                            comandoActualizar.Parameters.AddWithValue("@nueva_existencia", nuevaExistencia);

                            comandoActualizar.Parameters.AddWithValue("@fecha_hora", fechaHora);

                            comandoActualizar.Parameters.AddWithValue("@id_producto", idProducto);

                            int filasActualizadas = comandoActualizar.ExecuteNonQuery();

                            if (filasActualizadas == 0)
                            {
                                throw new Exception("No fue posible actualizar el inventario.");
                            }
                        }

                        string insertarMovimiento = @"
                            INSERT INTO movimiento_inventario
                                (id_producto, tipo_movimiento, fecha_hora, cantidad)
                            VALUES
                                (@id_producto, @tipo_movimiento, @fecha_hora, @cantidad);";

                        using (MySqlCommand comandoMovimiento = new MySqlCommand(insertarMovimiento, conexion, transaccion))
                        {
                            comandoMovimiento.Parameters.AddWithValue("@id_producto", idProducto);
                            comandoMovimiento.Parameters.AddWithValue("@tipo_movimiento", tipoMovimiento);
                            comandoMovimiento.Parameters.AddWithValue("@fecha_hora", fechaHora);
                            comandoMovimiento.Parameters.AddWithValue("@cantidad", cantidad); comandoMovimiento.ExecuteNonQuery();
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

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedoresAdmin frm = new frmProveedoresAdmin();

            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductosAdmin frm = new frmProductosAdmin();

            frm.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashAdmin frm = new frmDashAdmin();

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
    }
}
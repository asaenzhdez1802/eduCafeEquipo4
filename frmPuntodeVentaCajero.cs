using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmPuntodeVentaCajero : Form
    {
        private bool cargandoCategorias = false;

        public frmPuntodeVentaCajero()
        {
            InitializeComponent();

            // Eventos del formulario
            this.Load += frmPuntodeVentaCajero_Load;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            cmbBuscarCategoria.SelectedIndexChanged +=
                cmbBuscarCategoria_SelectedIndexChanged;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
        }

        private void frmPuntodeVentaCajero_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario();
            CargarCategorias();
            CargarProductos();
        }

        private void ConfigurarFormulario()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.SelectedIndex = 0;

            txtSubtotal.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtTotalRecibido.Clear();
            txtCambio.Text = "0.00";

            txtSubtotal.ReadOnly = true;
            txtTotalPagar.ReadOnly = true;
            txtCambio.ReadOnly = true;

            dgvProductosVenta.ClearSelection();
            dgvDetalleVenta.ClearSelection();

            lblNota.Text =
                "Selecciona un producto para comenzar la venta.";
        }

        private void CargarCategorias()
        {
            cargandoCategorias = true;

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
                        SELECT id_categoria, nombre
                        FROM categoria
                        WHERE estado = 'Activo'
                        ORDER BY nombre ASC;";

                    using (MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion))
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
                MessageBox.Show(
                    "No fue posible cargar las categorías.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                cargandoCategorias = false;
            }
        }

        private int ObtenerCategoriaSeleccionada()
        {
            if (cmbBuscarCategoria.SelectedValue == null)
            {
                return 0;
            }

            if (int.TryParse(
                cmbBuscarCategoria.SelectedValue.ToString(),
                out int idCategoria))
            {
                return idCategoria;
            }

            return 0;
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductosVenta.Rows.Clear();

                string nombreProducto =
                    txtBuscarProducto.Text.Trim();

                int idCategoria =
                    ObtenerCategoriaSeleccionada();

                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string consulta = @"
                        SELECT
                            p.id_producto,
                            p.nombre AS producto,
                            c.nombre AS categoria,
                            p.precio_venta,
                            COALESCE(i.existencia_actual, 0)
                                AS existencia_actual
                        FROM producto AS p
                        INNER JOIN categoria AS c
                            ON c.id_categoria = p.id_categoria
                        LEFT JOIN inventario AS i
                            ON i.id_producto = p.id_producto
                        WHERE p.estado = 'Activo'
                          AND (
                              @nombreProducto = ''
                              OR p.nombre LIKE @busqueda
                          )
                          AND (
                              @idCategoria = 0
                              OR p.id_categoria = @idCategoria
                          )
                        ORDER BY p.nombre ASC;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombreProducto",
                            nombreProducto
                        );

                        comando.Parameters.AddWithValue(
                            "@busqueda",
                            "%" + nombreProducto + "%"
                        );

                        comando.Parameters.AddWithValue(
                            "@idCategoria",
                            idCategoria
                        );

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                decimal precio =
                                    Convert.ToDecimal(
                                        lector["precio_venta"]
                                    );

                                int existencia =
                                    Convert.ToInt32(
                                        lector["existencia_actual"]
                                    );

                                dgvProductosVenta.Rows.Add(
                                    lector["id_producto"],
                                    lector["producto"],
                                    lector["categoria"],
                                    precio.ToString("0.00"),
                                    existencia,
                                    "Agregar"
                                );
                            }
                        }
                    }
                }

                dgvProductosVenta.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los productos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtBuscarProducto_TextChanged(
            object sender,
            EventArgs e)
        {
            CargarProductos();
        }

        private void cmbBuscarCategoria_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (!cargandoCategorias)
            {
                CargarProductos();
            }
        }

        private void btnCerrarSesion_Click(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿En realidad quieres cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                login formularioLogin = new login();
                formularioLogin.Show();
                this.Hide();
            }
        }
    }
}
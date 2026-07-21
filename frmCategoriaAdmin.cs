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
    public partial class frmCategoriaAdmin : Form
    {
        private int idCategoriaSeleccionada = 0;

        public frmCategoriaAdmin()
        {
            InitializeComponent();

            ConfigurarFormulario();

            this.Load += frmCategoriaAdmin_Load;
            txtBuscarCategoria.TextChanged += txtBuscarCategoria_TextChanged;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            btnGuardar.Click += btnGuardar_Click;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
        }

        private void ConfigurarFormulario()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            cmbEstado.SelectedIndex = -1;
        }

        private void frmCategoriaAdmin_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarCampos();
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

        private void CargarCategorias(string filtro = "")
        {
            try
            {
                dgvCategorias.Rows.Clear();

                using (MySqlConnection conexion = ObtenerConexion())
                {
                    string consulta = @"
                        SELECT
                            id_categoria,
                            nombre,
                            descripcion
                            FROM categoria
                            WHERE
                            @filtro = ''
                            OR nombre LIKE @busqueda
                            OR descripcion LIKE @busqueda
                            ORDER BY nombre ASC;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtro", filtro);
                        comando.Parameters.AddWithValue("@busqueda", "%" + filtro + "%");

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                dgvCategorias.Rows.Add(
                                    lector["id_categoria"].ToString(),
                                    lector["nombre"].ToString(),
                                    lector["descripcion"].ToString()
                                );
                            }
                        }
                    }
                }

                dgvCategorias.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar las categorías.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias(txtBuscarCategoria.Text.Trim());
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombreCategoria.Focus();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

            object valorId = fila.Cells["colIdCategoria"].Value;

            if (valorId == null)
            {
                return;
            }

            bool idCorrecto = int.TryParse(valorId.ToString(), out idCategoriaSeleccionada);

            if (!idCorrecto)
            {
                idCategoriaSeleccionada = 0;
                return;
            }

            CargarDatosCategoria(idCategoriaSeleccionada);
        }

        private void CargarDatosCategoria(int idCategoria)
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    string consulta = @"
                            SELECT
                            nombre,
                            descripcion,
                            estado
                            FROM categoria
                            WHERE id_categoria = @id_categoria;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@id_categoria",
                            idCategoria
                        );

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtNombreCategoria.Text =
                                    lector["nombre"].ToString();

                                txtDescripcionCategoria.Text =
                                    lector["descripcion"].ToString();

                                cmbEstado.SelectedItem =
                                    lector["estado"].ToString();

                                btnGuardar.Text = "Actualizar";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los datos de la categoría.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                string nombreCategoria = txtNombreCategoria.Text.Trim();

                if (ExisteNombreCategoria(
                    nombreCategoria,
                    idCategoriaSeleccionada))
                {
                    MessageBox.Show(
                        "Ya existe una categoría con ese nombre.",
                        "Categoría duplicada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtNombreCategoria.Focus();
                    return;
                }

                if (idCategoriaSeleccionada == 0)
                {
                    InsertarCategoria();
                }
                else
                {
                    ActualizarCategoria();
                }

                CargarCategorias(txtBuscarCategoria.Text.Trim());
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Ya existe una categoría con ese nombre.",
                        "Categoría duplicada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrió un error en la base de datos.\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show(
                    "Ingresa el nombre de la categoría.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombreCategoria.Focus();
                return false;
            }

            if (txtNombreCategoria.Text.Trim().Length > 80)
            {
                MessageBox.Show(
                    "El nombre de la categoría no puede superar los 80 caracteres.",
                    "Nombre demasiado largo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombreCategoria.Focus();
                return false;
            }

            if (txtDescripcionCategoria.Text.Trim().Length > 255)
            {
                MessageBox.Show(
                    "La descripción no puede superar los 255 caracteres.",
                    "Descripción demasiado larga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDescripcionCategoria.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona el estado de la categoría.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteNombreCategoria(string nombreCategoria,int idCategoria)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                string consulta = @"
                    SELECT COUNT(*)
                    FROM categoria
                    WHERE nombre = @nombre
                    AND id_categoria <> @id_categoria;";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombreCategoria);
                    comando.Parameters.AddWithValue("@id_categoria", idCategoria);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                    return cantidad > 0;
                }
            }
        }

        private void InsertarCategoria()
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO categoria
                    (nombre, descripcion, estado)
                    VALUES
                    (@nombre, @descripcion, @estado);";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    AgregarParametrosCategoria(comando);
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Categoría registrada correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ActualizarCategoria()
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                string consulta = @"
                    UPDATE categoria
                    SET
                        nombre = @nombre,
                        descripcion = @descripcion,
                        estado = @estado
                    WHERE id_categoria = @id_categoria;";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    AgregarParametrosCategoria(comando);

                    comando.Parameters.AddWithValue(
                        "@id_categoria",
                        idCategoriaSeleccionada
                    );

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Categoría actualizada correctamente.",
                "Actualización exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void AgregarParametrosCategoria(MySqlCommand comando)
        {
            comando.Parameters.AddWithValue(
                "@nombre",
                txtNombreCategoria.Text.Trim()
            );

            MySqlParameter descripcion = comando.Parameters.Add(
                "@descripcion",
                MySqlDbType.VarChar,
                255
            );

            if (string.IsNullOrWhiteSpace(txtDescripcionCategoria.Text))
            {
                descripcion.Value = DBNull.Value;
            }
            else
            {
                descripcion.Value =
                    txtDescripcionCategoria.Text.Trim();
            }

            comando.Parameters.AddWithValue(
                "@estado",
                cmbEstado.SelectedItem.ToString()
            );
        }

        private void LimpiarCampos()
        {
            idCategoriaSeleccionada = 0;

            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();

            cmbEstado.SelectedIndex = -1;

            btnGuardar.Text = "Guardar";

            dgvCategorias.ClearSelection();
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashAdmin frm = new frmDashAdmin();

            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
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
    }
}

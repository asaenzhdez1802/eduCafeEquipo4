using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace eduCafeEquipo4
{
    public partial class frmUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();

            ConfigurarFormulario();

            this.Load += frmUsuarios_Load;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            btnGuardar.Click += btnGuardar_Click;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
        }

        private void ConfigurarFormulario()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Cajero");

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            txtContrasena.UseSystemPasswordChar = true;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            LimpiarCampos();
        }

        private MySqlConnection ObtenerConexion()
        {
            Conexion objetoConexion = new Conexion();

            MySqlConnection conexion = objetoConexion.GetConexion();

            if (conexion == null)
            {
                throw new Exception(
                    "No fue posible establecer conexión con la base de datos."
                );
            }

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            return conexion;
        }

        private void CargarUsuarios(string filtro = "")
        {
            try
            {
                dgvUsuarios.Rows.Clear();

                using (MySqlConnection conexion = ObtenerConexion())
                {
                    string consulta = @"
                        SELECT
                            id_usuario,
                            nombre_usuario,
                            CONCAT_WS(
                                ' ',
                                nombres,
                                primer_apellido,
                                NULLIF(segundo_apellido, '')
                            ) AS nombre_completo,
                            rol,
                            estado
                        FROM usuario
                        WHERE
                            @filtro = ''
                            OR nombre_usuario LIKE @busqueda
                            OR nombres LIKE @busqueda
                            OR primer_apellido LIKE @busqueda
                            OR segundo_apellido LIKE @busqueda
                        ORDER BY id_usuario ASC;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@filtro",
                            filtro
                        );

                        comando.Parameters.AddWithValue(
                            "@busqueda",
                            "%" + filtro + "%"
                        );

                        using (MySqlDataReader lector =
                               comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                dgvUsuarios.Rows.Add(
                                    lector["id_usuario"].ToString(),
                                    lector["nombre_usuario"].ToString(),
                                    lector["nombre_completo"].ToString(),
                                    lector["rol"].ToString(),
                                    lector["estado"].ToString(),
                                    "Editar"
                                );
                            }
                        }
                    }
                }

                dgvUsuarios.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los usuarios.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void txtBuscarNombre_TextChanged(
            object sender,
            EventArgs e)
        {
            CargarUsuarios(txtBuscarNombre.Text.Trim());
        }
        
        private void dgvUsuarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object valorId = dgvUsuarios.Rows[e.RowIndex]
                                        .Cells["colIdUsuario"]
                                        .Value;

            if (valorId == null)
            {
                return;
            }

            bool idValido = int.TryParse(
                valorId.ToString(),
                out idUsuarioSeleccionado
            );

            if (!idValido)
            {
                return;
            }

            CargarDatosUsuario(idUsuarioSeleccionado);
        }

        private void CargarDatosUsuario(int idUsuario)
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    string consulta = @"
                        SELECT
                            nombres,
                            primer_apellido,
                            segundo_apellido,
                            nombre_usuario,
                            contrasena,
                            rol,
                            estado
                        FROM usuario
                        WHERE id_usuario = @id_usuario;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@id_usuario",
                            idUsuario
                        );

                        using (MySqlDataReader lector =
                               comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtNombreUsuario.Text =
                                    lector["nombre_usuario"].ToString();

                                txtNombresReales.Text =
                                    lector["nombres"].ToString();

                                txtPrimerApellido.Text =
                                    lector["primer_apellido"].ToString();

                                txtSegundoApellido.Text =
                                    lector["segundo_apellido"].ToString();

                                txtContrasena.Text =
                                    lector["contrasena"].ToString();

                                cmbRol.SelectedItem =
                                    lector["rol"].ToString();

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
                    "No fue posible cargar los datos del usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnNuevoUsuario_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
            txtNombreUsuario.Focus();
        }

        private void LimpiarCampos()
        {
            idUsuarioSeleccionado = 0;

            txtNombreUsuario.Clear();
            txtNombresReales.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtContrasena.Clear();

            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            btnGuardar.Text = "Guardar";

            dgvUsuarios.ClearSelection();
        }


        private void btnGuardar_Click(object sender,EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                bool usuarioDuplicado = ExisteNombreUsuario(
                    txtNombreUsuario.Text.Trim(),
                    idUsuarioSeleccionado
                );

                if (usuarioDuplicado)
                {
                    MessageBox.Show(
                        "El nombre de usuario ya está registrado.",
                        "Usuario duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtNombreUsuario.Focus();
                    return;
                }

                if (idUsuarioSeleccionado == 0)
                {
                    InsertarUsuario();
                }
                else
                {
                    ActualizarUsuario();
                }

                CargarUsuarios(txtBuscarNombre.Text.Trim());
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "El nombre de usuario ya está registrado.",
                        "Usuario duplicado",
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
                    "Ocurrió un error.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show(
                    "Ingresa el nombre de usuario.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombreUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombresReales.Text))
            {
                MessageBox.Show(
                    "Ingresa los nombres reales.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombresReales.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            {
                MessageBox.Show(
                    "Ingresa el primer apellido.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPrimerApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show(
                    "Ingresa la contraseña.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtContrasena.Focus();
                return false;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona el rol del usuario.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbRol.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona el estado del usuario.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteNombreUsuario(
            string nombreUsuario,
            int idUsuario)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                string consulta = @"
                    SELECT COUNT(*)
                    FROM usuario
                    WHERE nombre_usuario = @nombre_usuario
                    AND id_usuario <> @id_usuario;";

                using (MySqlCommand comando =
                       new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@nombre_usuario",
                        nombreUsuario
                    );

                    comando.Parameters.AddWithValue(
                        "@id_usuario",
                        idUsuario
                    );

                    int cantidad = Convert.ToInt32(
                        comando.ExecuteScalar()
                    );

                    return cantidad > 0;
                }
            }
        }

        private void InsertarUsuario()
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO usuario
                    (
                        nombres,
                        primer_apellido,
                        segundo_apellido,
                        nombre_usuario,
                        contrasena,
                        rol,
                        estado
                    )
                    VALUES
                    (
                        @nombres,
                        @primer_apellido,
                        @segundo_apellido,
                        @nombre_usuario,
                        @contrasena,
                        @rol,
                        @estado
                    );";

                using (MySqlCommand comando =
                       new MySqlCommand(consulta, conexion))
                {
                    AgregarParametrosUsuario(comando);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario registrado correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ActualizarUsuario()
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                string consulta = @"
                    UPDATE usuario
                    SET
                        nombres = @nombres,
                        primer_apellido = @primer_apellido,
                        segundo_apellido = @segundo_apellido,
                        nombre_usuario = @nombre_usuario,
                        contrasena = @contrasena,
                        rol = @rol,
                        estado = @estado
                    WHERE id_usuario = @id_usuario;";

                using (MySqlCommand comando =
                       new MySqlCommand(consulta, conexion))
                {
                    AgregarParametrosUsuario(comando);

                    comando.Parameters.AddWithValue(
                        "@id_usuario",
                        idUsuarioSeleccionado
                    );

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        throw new Exception(
                            "No se encontró el usuario que intentas actualizar."
                        );
                    }
                }
            }

            MessageBox.Show(
                "Usuario actualizado correctamente.",
                "Actualización exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void AgregarParametrosUsuario(
            MySqlCommand comando)
        {
            comando.Parameters.AddWithValue(
                "@nombres",
                txtNombresReales.Text.Trim()
            );

            comando.Parameters.AddWithValue(
                "@primer_apellido",
                txtPrimerApellido.Text.Trim()
            );

            MySqlParameter segundoApellido =
                comando.Parameters.Add(
                    "@segundo_apellido",
                    MySqlDbType.VarChar,
                    50
                );

            if (string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                segundoApellido.Value = DBNull.Value;
            }
            else
            {
                segundoApellido.Value =
                    txtSegundoApellido.Text.Trim();
            }

            comando.Parameters.AddWithValue(
                "@nombre_usuario",
                txtNombreUsuario.Text.Trim()
            );

            comando.Parameters.AddWithValue(
                "@contrasena",
                txtContrasena.Text
            );

            comando.Parameters.AddWithValue(
                "@rol",
                cmbRol.SelectedItem.ToString()
            );

            comando.Parameters.AddWithValue(
                "@estado",
                cmbEstado.SelectedItem.ToString()
            );
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

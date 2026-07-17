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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Conexion coneccion = new Conexion();
            MySqlConnection Conex = coneccion.GetConexion();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contra = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexion con = new Conexion();

            try
            {
                using (var conexion = con.GetConexion())
                {
                    if (conexion == null) return;

                    string query = "SELECT nombres, primer_apellido, segundo_apellido, rol, estado FROM usuario WHERE nombre_usuario = @user AND contrasena = @pass";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@user", usuario);
                        comando.Parameters.AddWithValue("@pass", contra);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombres = reader["nombres"].ToString();
                                string primerApellido = reader["primer_apellido"].ToString();
                                string segundoApellido = reader["segundo_apellido"].ToString();

                                string nombreCompleto = $"{nombres} {primerApellido} {segundoApellido}".Trim();

                                string rol = reader["rol"].ToString();
                                string estado = reader["estado"].ToString();

                                if (estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Error: Tu cuenta está desactivada. Contacta al administrador.",
                                                    "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txtContrasena.Clear();
                                    txtUsuario.Clear();
                                    return;
                                }

                                MessageBox.Show($"¡Bienvenido al Sistema, {nombreCompleto}!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                                {
                                    frmDashAdmin formularioPrincipal = new frmDashAdmin();
                                    formularioPrincipal.Show();
                                }
                                else if (rol.Equals("Cajero", StringComparison.OrdinalIgnoreCase))
                                {
                                    frmPuntodeVentaCajero formularioCajero = new frmPuntodeVentaCajero();
                                    formularioCajero.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Tu rol no está registrado en el sistema.", "Error de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Los datos son incorrectos. Intente de nuevo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                txtContrasena.Clear();
                                txtUsuario.Clear();
                            }
                        }
                    }

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
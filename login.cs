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
using System.Speech.Synthesis;

namespace eduCafeEquipo4
{
    public partial class login : Form
    {
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        private bool audioAccesibilidadActivo = false;
        private string ultimoMensaje = "";
        private DateTime ultimaLectura = DateTime.MinValue;

        public login()
        {
            InitializeComponent();

            Conexion coneccion = new Conexion();
            MySqlConnection Conex = coneccion.GetConexion();
            voz.Volume = 100;
            voz.Rate = 0;
            btnAudio.Text = "Audio: Desactivado";
            ConfigurarAudioAccesibilidad();
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

                    string query = "SELECT id_usuario, contrasena, nombres, primer_apellido, segundo_apellido, rol, estado " +   "FROM usuario " +  "WHERE nombre_usuario = @user " +"AND BINARY contrasena = @pass";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@user", usuario);
                        comando.Parameters.AddWithValue("@pass", contra);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idUsuario = Convert.ToInt32(reader["id_usuario"]);
                                string contrasenaBD = reader["contrasena"].ToString();

                                if (!contrasenaBD.Equals(contra, StringComparison.Ordinal))
                                {
                                    MessageBox.Show("Los datos son incorrectos. Intente de nuevo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtContrasena.Clear();
                                    txtUsuario.Clear();
                                    return;
                                }

                                string nombres = reader["nombres"].ToString();
                                string primerApellido = reader["primer_apellido"].ToString();
                                string segundoApellido = reader["segundo_apellido"].ToString();
                                string nombreCompleto = $"{nombres} {primerApellido} {segundoApellido}".Trim();
                                string rol = reader["rol"].ToString();
                                string estado = reader["estado"].ToString();

                                if (estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Error: Tu cuenta está desactivada. Contacta al administrador.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    frmPuntodeVentaCajero formularioCajero = new frmPuntodeVentaCajero(idUsuario, nombreCompleto);
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConfigurarAudioAccesibilidad()
        {
            AgregarLectura(txtUsuario, "Usuario");
            AgregarLectura(txtContrasena, "Contraseña");
            AgregarLectura(chkMostrarContrasena, "Mostrar contraseña");
            AgregarLectura(btnIniciarSesion, "Iniciar sesión");
            AgregarLectura(btnSalir, "Salir");
            AgregarLectura(btnAudio, "Activar o desactivar audio");
        }

        private void AgregarLectura(Control control, string mensaje)
        {
            control.AccessibleName = mensaje;

            control.MouseEnter += (sender, e) =>
            {
                ReproducirMensaje(mensaje);
            };

            control.Enter += (sender, e) =>
            {
                ReproducirMensaje(mensaje);
            };
        }

        private void ReproducirMensaje(string mensaje)
        {
            if (!audioAccesibilidadActivo)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(mensaje))
            {
                return;
            }

            bool mensajeRepetido = ultimoMensaje == mensaje;
            bool acabaDeReproducirse = (DateTime.Now - ultimaLectura).TotalMilliseconds < 1000;

            if (mensajeRepetido && acabaDeReproducirse)
            {
                return;
            }

            ultimoMensaje = mensaje;
            ultimaLectura = DateTime.Now;
            voz.SpeakAsyncCancelAll();
            voz.SpeakAsync(mensaje);
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            voz.SpeakAsyncCancelAll();
            if (!audioAccesibilidadActivo)
            {
                audioAccesibilidadActivo = true;
                btnAudio.Text = "Audio: Activado";
                ultimoMensaje = "";
                ultimaLectura = DateTime.MinValue;
                voz.SpeakAsync("Asistencia de voz activada");
            }
            else
            {
                voz.SpeakAsync("Asistencia de voz desactivada");
                audioAccesibilidadActivo = false;
                btnAudio.Text = "Audio: Desactivado";
                ultimoMensaje = "";
                ultimaLectura = DateTime.MinValue;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            voz.SpeakAsyncCancelAll();
            voz.Dispose();
            base.OnFormClosed(e);
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContrasena.Checked)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
    }
}
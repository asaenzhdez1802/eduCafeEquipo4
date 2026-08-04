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

            voz.Volume = 100;
            voz.Rate = 0;

            btnAudio.Text = "Audio: Desactivado";

            ConfigurarAudioAccesibilidad();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contra = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(contra))
            {
                MessageBox.Show(
                    "Por favor, llena todos los campos.",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Conexion con = new Conexion();

            try
            {
                using (MySqlConnection conexion = con.GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show(
                            "No se pudo establecer conexión con la base de datos.",
                            "Error de conexión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    /*
                     * Se agregó id_usuario y nombre_usuario
                     * para guardar la sesión del usuario.
                     */
                    string query = @"
                        SELECT
                            id_usuario,
                            nombres,
                            primer_apellido,
                            segundo_apellido,
                            nombre_usuario,
                            rol,
                            estado
                        FROM usuario
                        WHERE nombre_usuario = @user
                          AND contrasena = SHA2(@pass, 256)
                        LIMIT 1;";

                    using (MySqlCommand comando =
                           new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(
                            "@user",
                            MySqlDbType.VarChar
                        ).Value = usuario;

                        comando.Parameters.Add(
                            "@pass",
                            MySqlDbType.VarChar
                        ).Value = contra;

                        using (MySqlDataReader reader =
                               comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                /*
                                 * Se recupera el ID directamente
                                 * desde la tabla usuario.
                                 */
                                int idUsuario =
                                    Convert.ToInt32(
                                        reader["id_usuario"]
                                    );

                                string nombres =
                                    reader["nombres"].ToString();

                                string primerApellido =
                                    reader["primer_apellido"].ToString();

                                string segundoApellido =
                                    reader["segundo_apellido"].ToString();

                                string nombreUsuario =
                                    reader["nombre_usuario"].ToString();

                                string rol =
                                    reader["rol"].ToString();

                                string estado =
                                    reader["estado"].ToString();

                                string nombreCompleto =
                                    $"{nombres} {primerApellido} {segundoApellido}"
                                    .Trim();

                                if (estado.Equals(
                                    "Inactivo",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show(
                                        "Error: Tu cuenta está desactivada. Contacta al administrador.",
                                        "Acceso denegado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );

                                    LimpiarCampos();
                                    return;
                                }

                                if (!rol.Equals(
                                        "Administrador",
                                        StringComparison.OrdinalIgnoreCase) &&
                                    !rol.Equals(
                                        "Cajero",
                                        StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show(
                                        "Tu rol no está registrado en el sistema.",
                                        "Error de permisos",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                    );

                                    return;
                                }

                                /*
                                 * AQUÍ SE GUARDA LA SESIÓN.
                                 *
                                 * Estos datos estarán disponibles
                                 * tanto en Punto de venta como
                                 * en Mis ventas.
                                 */
                                SesionActual.IniciarSesion(
                                    idUsuario,
                                    nombreCompleto,
                                    nombreUsuario,
                                    rol
                                );

                                MessageBox.Show(
                                    $"¡Bienvenido al Sistema, {nombreCompleto}!",
                                    "Acceso concedido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                if (rol.Equals(
                                    "Administrador",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    frmDashAdmin formularioPrincipal =
                                        new frmDashAdmin();

                                    formularioPrincipal.Show();
                                    Hide();
                                }
                                else if (rol.Equals(
                                    "Cajero",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    frmPuntodeVentaCajero formularioCajero =
                                        new frmPuntodeVentaCajero();

                                    formularioCajero.Show();
                                    Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Los datos son incorrectos. Intente de nuevo.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error al conectarse a la base de datos:\n" +
                    ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConfigurarAudioAccesibilidad()
        {
            AgregarLectura(txtUsuario, "Usuario");
            AgregarLectura(txtContrasena, "Contraseña");
            AgregarLectura(
                chkMostrarContrasena,
                "Mostrar contraseña"
            );
            AgregarLectura(
                btnIniciarSesion,
                "Iniciar sesión"
            );
            AgregarLectura(btnSalir, "Salir");
            AgregarLectura(
                btnAudio,
                "Activar o desactivar audio"
            );
        }

        private void AgregarLectura(
            Control control,
            string mensaje)
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

            bool mensajeRepetido =
                ultimoMensaje == mensaje;

            bool acabaDeReproducirse =
                (DateTime.Now - ultimaLectura)
                .TotalMilliseconds < 1000;

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

                voz.SpeakAsync(
                    "Asistencia de voz activada"
                );
            }
            else
            {
                voz.SpeakAsync(
                    "Asistencia de voz desactivada"
                );

                audioAccesibilidadActivo = false;
                btnAudio.Text = "Audio: Desactivado";

                ultimoMensaje = "";
                ultimaLectura = DateTime.MinValue;
            }
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            voz.SpeakAsyncCancelAll();
            voz.Dispose();

            base.OnFormClosed(e);
        }

        private void chkMostrarContrasena_CheckedChanged(
            object sender,
            EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar =
                !chkMostrarContrasena.Checked;
        }
    }
}
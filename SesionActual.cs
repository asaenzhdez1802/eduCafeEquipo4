using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eduCafeEquipo4
{
    public static class SesionActual
    {
        public static int IdUsuario { get; private set; }
        public static string NombreCompleto { get; private set; } = "";
        public static string NombreUsuario { get; private set; } = "";
        public static string Rol { get; private set; } = "";

        public static bool HaySesionActiva
        {
            get
            {
                return IdUsuario > 0;
            }
        }

        public static void IniciarSesion(
            int idUsuario,
            string nombreCompleto,
            string nombreUsuario,
            string rol)
        {
            IdUsuario = idUsuario;
            NombreCompleto = nombreCompleto;
            NombreUsuario = nombreUsuario;
            Rol = rol;
        }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreCompleto = "";
            NombreUsuario = "";
            Rol = "";
        }
    }
}

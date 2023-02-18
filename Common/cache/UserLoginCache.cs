using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.cache
{
    public static class UserLoginCache
    {
        public static int id_Empleado { get; set; }
        public static string Usuario { get; set; }
        public static string Email { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Telefono { get; set; }
        public static string Dirección { get; set; }
        public static string Contraseña_Encriptada { get; set; }
        public static string Contraseña { get; set; }
        public static string Cargo { get; set; }
    }
}

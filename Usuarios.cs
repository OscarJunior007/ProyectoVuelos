using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVuelos
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public  Usuarios(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }

    }
}

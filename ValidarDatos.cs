using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace BibliotecaVuelos
{
    public class ValidarDatos
    {
        private List<Usuarios> users = new List<Usuarios>();

       

        public bool GuardarUsuario(string usuario, string contrasena)
        {

            bool  x = false;
            try
            {
                
                 if(File.Exists(@"C:\Users\Oscar\source\repos\VentanaLogin\bin\Debug\DATOS GUARDADOS\" + $"{usuario}.txt"))
                {
                    x = false;
                }
                else
                {
                    TextWriter GuardarDatos = new StreamWriter(@"C:\Users\Oscar\source\repos\VentanaLogin\bin\Debug\DATOS GUARDADOS\" + $"{usuario}.txt", true);
                    GuardarDatos.WriteLine(contrasena);
                    GuardarDatos.Close();
                   x = true;
                }

            }
            catch (Exception)
            {

            }

            return x;

            //    if (users.Any(user => user.Usuario == usuario ))
            //    {
            //        return false;
            //    }
            //    else
            //    {

            //        users.Add(new Usuarios(usuario, contrasena));



            //    }

        }

       
        public bool RectificarDatos(string usuario, string contrasena)
        {
            bool encontrado = false;

            try
            {
                using (TextReader VerificarDatos = new StreamReader(@"C:\Users\Oscar\source\repos\VentanaLogin\bin\Debug\DATOS GUARDADOS\" + $"{usuario}.txt" ))
                {
                    string ContraGuardada = VerificarDatos.ReadLine();

                    
                    if (ContraGuardada == contrasena)
                    {
                        encontrado = true;
                    }
                }
            }
            catch (FileNotFoundException)
            {

                return false;
            }
            

            return encontrado;


      
            
            //return users.Any(user => user.Usuario == usuario && user.Contrasena == contrasena);

        }
    }

    
}

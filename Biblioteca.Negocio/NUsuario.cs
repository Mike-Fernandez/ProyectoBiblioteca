using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Datos;

namespace Biblioteca.Negocio
{
    public class NUsuario
    {
        public static DataTable listarProfesores()
        {
            DUsuario data = new DUsuario();
            return data.listarProfesores();
        }

        public static DataTable Login(string email, string clave)
        {
            DUsuario data = new DUsuario();
            return data.Login(email, clave);
        }

        public static DataTable BuscarProfesor(string nombre)
        {
            DUsuario data = new DUsuario();
            return data.BuscarProfesor(nombre);
        }
    }
}

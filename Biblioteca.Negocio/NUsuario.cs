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
    }
}

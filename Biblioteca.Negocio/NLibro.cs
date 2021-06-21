using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro data = new DLibro();
            return data.Listar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        public int codigo { get; set; }
        public int codigoLibro { get; set; }
        public int codigoProfesor { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public bool activo { get; set; }
    }
}

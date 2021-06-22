using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Libro
    {
        public int codigo { get; set; }
        public int numeroEjemplares { get; set; }
        public int isbn { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string editionYear { get; set; }
        public int numeroEdicion { get; set; }
        public string pais { get; set; }
        public string idioma { get; set; }
        public string materia { get; set; }
        public int numeroPaginas { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
    }
}

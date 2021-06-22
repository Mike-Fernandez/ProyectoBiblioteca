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
        public static DataTable listarTodos()
        {
            DLibro data = new DLibro();
            return data.listarTodos();
        }

        public static DataTable listarAvailable()
        {
            DLibro data = new DLibro();
            return data.listarAvailable();
        }

        public static DataTable listarAvailableSmall()
        {
            DLibro data = new DLibro();
            return data.listarAvailableSmall();
        }

        public static DataTable buscarTitulo(string valor)
        {
            DLibro data = new DLibro();
            return data.buscarTitulo(valor);
        }

        public static DataTable buscarAutor(string valor)
        {
            DLibro data = new DLibro();
            return data.buscarAutor(valor);
        }

        public static string Insertar(int numeroEjemplares, int isbn, string titulo, string autor, 
            string editorial, string editionYear, int numeroEdicion, string pais, string idioma, 
            string materia, int numeroPaginas, string ubicacion, string descripcion)
        {
            DLibro datos = new DLibro();
            Libro obj = new Libro();

            obj.numeroEjemplares = numeroEjemplares;
            obj.isbn = isbn;
            obj.titulo = titulo;
            obj.autor = autor;
            obj.editorial = editorial;
            obj.editionYear = editionYear;
            obj.numeroEdicion = numeroEdicion;
            obj.pais = pais;
            obj.idioma = idioma;
            obj.materia = materia;
            obj.numeroPaginas = numeroPaginas;
            obj.ubicacion = ubicacion;
            obj.descripcion = descripcion;
            return datos.Insertar(obj);
        }

        public static string Actualizar(int numeroEjemplares, int isbn, string titulo, string autor,
            string editorial, string editionYear, int numeroEdicion, string pais, string idioma,
            string materia, int numeroPaginas, string ubicacion, string descripcion)
        {
            DLibro datos = new DLibro();
            Libro obj = new Libro();

            obj.numeroEjemplares = numeroEjemplares;
            obj.isbn = isbn;
            obj.titulo = titulo;
            obj.autor = autor;
            obj.editorial = editorial;
            obj.editionYear = editionYear;
            obj.numeroEdicion = numeroEdicion;
            obj.pais = pais;
            obj.idioma = idioma;
            obj.materia = materia;
            obj.numeroPaginas = numeroPaginas;
            obj.ubicacion = ubicacion;
            obj.descripcion = descripcion;
            return datos.Actualizar(obj);
        }

        public static string Eliminar(int id)
        {
            DLibro data = new DLibro();
            return data.Eliminar(id);
        }

        public static string Prestar(int id)
        {
            DLibro data = new DLibro();
            return data.Prestar(id);
        }

        public static string Devolver(int id)
        {
            DLibro data = new DLibro();
            return data.Devolver(id);
        }
    }
}

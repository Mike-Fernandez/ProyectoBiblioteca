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
    public class NPrestamo
    {
        public static DataTable ListarPorProfesor(int id)
        {
            DPrestamo data = new DPrestamo();
            return data.listarPorProfesor(id);
        }

        public static string crearPrestamo(int codigoLibro, int codigoProfesor, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            DPrestamo data = new DPrestamo();
            DLibro libro = new DLibro();
            Prestamo obj = new Prestamo();

            if (fechaDevolucion.CompareTo(fechaPrestamo) < 0)
                return "Esta fecha es incorrecta, la fecha de devolucion no puede ser previa a la fecha de prestamo";

            obj.codigoLibro = codigoLibro;
            obj.codigoProfesor = codigoProfesor;
            obj.fechaPrestamo = fechaPrestamo;
            obj.fechaDevolucion = fechaDevolucion;

            string resolve = libro.Prestar(codigoLibro);

            if(resolve == "OK")
            {
                return data.crearPrestamo(obj);
            } else
            {
                return "No hay ejemplares para prestar";
            }
        }

        public static string devolverPrestamo(int idPrestamo)
        {
            DPrestamo data = new DPrestamo();
            DLibro libro = new DLibro();
            int codigoLibro = data.getLibroFromPrestamo(idPrestamo);

            string resolve = libro.Devolver(codigoLibro);

            if (resolve == "OK")
            {
                return data.devolverPrestamo(idPrestamo);
            }
            else
            {
                return "No hay ejemplares para prestar";
            }
        }
    }
}

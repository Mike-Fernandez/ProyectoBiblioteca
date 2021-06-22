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
            Prestamo obj = new Prestamo();

            obj.codigoLibro = codigoLibro;
            obj.codigoProfesor = codigoProfesor;
            obj.fechaPrestamo = fechaPrestamo;
            obj.fechaDevolucion = fechaDevolucion;

            return data.crearPrestamo(obj);
        }

        public static string devolverPrestamo(int id)
        {
            DPrestamo data = new DPrestamo();
            return data.devolverPrestamo(id);
        }
    }
}

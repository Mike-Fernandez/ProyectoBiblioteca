using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class DPrestamo
    {
        public DataTable listarPorProfesor(int id)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("prestamo_listar_por_profesor", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigo_profesor", SqlDbType.Int).Value = id;
                sqlCon.Open();
                resultado = command.ExecuteReader();
                table.Load(resultado);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string crearPrestamo(Prestamo obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("prestamo_crear", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigo_libro", SqlDbType.Int).Value = obj.codigoLibro;
                command.Parameters.Add("@codigo_profesor", SqlDbType.Int).Value = obj.codigoProfesor;
                command.Parameters.Add("@fecha_prestamo", SqlDbType.Date).Value = obj.fechaPrestamo;
                command.Parameters.Add("@fecha_limite_devolucion", SqlDbType.Date).Value = obj.fechaDevolucion;
                sqlCon.Open();
                rpta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;
        }

        public string devolverPrestamo(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("prestamo_devolver", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigo", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;
        }
    }
}

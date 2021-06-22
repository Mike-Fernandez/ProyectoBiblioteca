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
    public class DLibro
    {
        public DataTable listarTodos()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_listar_todos", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
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

        public DataTable listarAvailable()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_listar_available", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
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

        public DataTable listarAvailableSmall()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_listar_available_small", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
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

        public DataTable buscarTitulo(string valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_buscar_titulo", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public DataTable buscarAutor(string valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_buscar_autor", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public DataTable buscarTituloAvailable(string valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_buscar_titulo_available", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public DataTable buscarAutorAvailable(string valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_buscar_autor_available", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public string Existe(string valor)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_existe", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                command.Parameters.Add(parExiste);
                sqlCon.Open();
                command.ExecuteNonQuery();
                rpta = Convert.ToString(parExiste.Value);
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

        public string Insertar(Libro obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_insertar", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@numero_ejemplares", SqlDbType.Int).Value = obj.numeroEjemplares;
                command.Parameters.Add("@isbn", SqlDbType.Int).Value = obj.isbn;
                command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj.titulo;
                command.Parameters.Add("@autor", SqlDbType.VarChar).Value = obj.autor;
                command.Parameters.Add("@editorial", SqlDbType.VarChar).Value = obj.editorial;
                command.Parameters.Add("@anio_edicion", SqlDbType.VarChar).Value = obj.editionYear;
                command.Parameters.Add("@numero_edicion", SqlDbType.Int).Value = obj.numeroEdicion;
                command.Parameters.Add("@pais", SqlDbType.VarChar).Value = obj.pais;
                command.Parameters.Add("@idioma", SqlDbType.VarChar).Value = obj.idioma;
                command.Parameters.Add("@materia", SqlDbType.VarChar).Value = obj.materia;
                command.Parameters.Add("@numero_paginas", SqlDbType.Int).Value = obj.numeroPaginas;
                command.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = obj.ubicacion;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.descripcion;
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

        public string Actualizar(Libro obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_actualizar", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@numero_ejemplares", SqlDbType.Int).Value = obj.numeroEjemplares;
                command.Parameters.Add("@isbn", SqlDbType.Int).Value = obj.isbn;
                command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj.titulo;
                command.Parameters.Add("@autor", SqlDbType.VarChar).Value = obj.autor;
                command.Parameters.Add("@editorial", SqlDbType.VarChar).Value = obj.editorial;
                command.Parameters.Add("@anio_edicion", SqlDbType.VarChar).Value = obj.editionYear;
                command.Parameters.Add("@numero_edicion", SqlDbType.Int).Value = obj.numeroEdicion;
                command.Parameters.Add("@pais", SqlDbType.VarChar).Value = obj.pais;
                command.Parameters.Add("@idioma", SqlDbType.VarChar).Value = obj.idioma;
                command.Parameters.Add("@materia", SqlDbType.VarChar).Value = obj.materia;
                command.Parameters.Add("@numero_paginas", SqlDbType.Int).Value = obj.numeroPaginas;
                command.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = obj.ubicacion;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.descripcion;
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

        public string Eliminar(int id)
        {
            string rpta = "";
            SqlConnection slqCon = new SqlConnection();
            try
            {
                slqCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_eliminar", slqCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigo", SqlDbType.Int).Value = id;
                slqCon.Open();
                rpta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (slqCon.State == ConnectionState.Open) slqCon.Close();
            }
            return rpta;
        }

        public string Prestar(int codigo)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_prestamo", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
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

        public string Devolver(int codigo)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("libro_devolver", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DUsuario
    {
        public DataTable listarProfesores()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().crearConexion();
                SqlCommand command = new SqlCommand("profesor_listar", sqlCon);
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
    }
}

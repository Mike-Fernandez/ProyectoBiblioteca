using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        private string database;
        private string server;
//        private string[] server = new string[3];
        private string user;
        private string key;
        private bool seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.database = "NCapas_biblioteca";
            this.server = "NCAPASBIBLIOTECA";
            this.user = "sa";
            this.key = "root";
            this.seguridad = false;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.server + "; Database=" + this.database;
                if (this.seguridad == true)
                {
                    cadena.ConnectionString += "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString += "; User Id=" + this.user + "; Password=" + this.key;
                }
            }
            catch (Exception err)
            {
                cadena = null;
                throw err;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}

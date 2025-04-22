using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_GESTION.DATOS
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private static Conexion Con = null;

        //CONSTRUCTOR DE LA CLASE

        private Conexion() {
            this.Base = "DB_gestion_empleados";
            this.Servidor = "XD\\SQLEXPRESS";
            this.Usuario = "XD\\hack4"; 
        }

        public SqlConnection CrearConexion() {

            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=XD\\SQLEXPRESS;DataBase=DB_gestion_empleados;Integrated Security=True;";

            }
            catch (Exception Ex)
            {
                Cadena = null;

                throw Ex;
            }

            return Cadena;
        
        }

        public static Conexion CrearInstancia() {

            if (Con == null)
            {
                Con = new Conexion();

            }

            return Con;
        
        }

    }
}

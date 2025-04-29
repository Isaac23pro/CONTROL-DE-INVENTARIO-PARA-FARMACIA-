using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DATOS
{
    public static class ConexioDB
    {
        // Lee la cadena de conexión desde App.config (clave: ConexionFarmacia)
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionFarmacia"].ConnectionString;

        // Método que devuelve una conexión abierta a la base de datos
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
} 
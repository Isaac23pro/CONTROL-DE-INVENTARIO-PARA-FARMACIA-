﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Conexion
    {
        private string connectionString = "Server=XD\\SQLEXPRESS;Database=FarmaciaGenesisAPP; Trusted_Connection=True;Encrypt=False;";

        //OE SOLO DESCOMENTA TU CADENA DE CONEXION Y COMENTA LA MI CADENA DE CONEXION
        //private string connectionString = "Server=XD\\SQLEXPRESS;Database=FarmaciaGenesisDIFINITIVO; Trusted_Connection=True;Encrypt=False;"; // Coloca tu cadena de conexión

        // Método para obtener la conexión
        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la conexión: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion(SqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }

    }
}

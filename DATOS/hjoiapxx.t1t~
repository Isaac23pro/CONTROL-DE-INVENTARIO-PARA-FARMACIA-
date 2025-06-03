using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DATOS
{
    public class MarcaDatos
    {
        private readonly Conexion conexion = new Conexion();
        public List<Marca> ObtenerMarcas()
        {
            List<Marca> marcas = new List<Marca>();

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    string query = "SELECT IdMarca, Nombre FROM Marca"; // Ajusta el nombre de la tabla y columnas según tu base de datos
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marcas.Add(new Marca
                            {
                                IdMarca = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las marcas: " + ex.Message);
            }

            return marcas;
        }
    }
}

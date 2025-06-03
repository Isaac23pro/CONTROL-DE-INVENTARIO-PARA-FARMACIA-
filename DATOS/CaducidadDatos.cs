using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace DATOS
{
    public class CaducidadDatos
    {

        private Conexion conexion = new Conexion();

        public List<Caducidad> ObtenerProductosCaducidad()
        {
            List<Caducidad> listaCaducidad = new List<Caducidad>();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                // Aseguramos que la conexión se abre correctamente
                comando.Connection = conexion.ObtenerConexion();
                comando.CommandText = @"SELECT 
                           c.IdCaducidad,
                           c.IdProducto,
                           c.IdLote,
                           c.FechaCaducidad,
                           c.Cantidad,
                           c.Estado,
                           c.Observaciones,
                           p.NombreComercial as NombreProducto,
                           cat.Nombre as Categoria,
                           DATEDIFF(day, GETDATE(), c.FechaCaducidad) as DiasRestantes
                       FROM CaducidadProducto c
                       INNER JOIN Producto p ON c.IdProducto = p.IdProducto
                       INNER JOIN CategoriaFarmaco cat ON p.IdCategoria = cat.IdCategoria
                       WHERE c.FechaCaducidad >= GETDATE()
                       ORDER BY c.FechaCaducidad ASC";

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Caducidad caducidad = new Caducidad
                    {
                        IdCaducidad = Convert.ToInt32(lector["IdCaducidad"]),
                        IdProducto = Convert.ToInt32(lector["IdProducto"]),
                        IdLote = Convert.ToInt32(lector["IdLote"]),
                        FechaCaducidad = Convert.ToDateTime(lector["FechaCaducidad"]),
                        Cantidad = Convert.ToDecimal(lector["Cantidad"]),
                        Estado = lector["Estado"].ToString(),
                        Observaciones = lector["Observaciones"].ToString(),
                        NombreProducto = lector["NombreProducto"].ToString(),
                        Categoria = lector["Categoria"].ToString(),
                        DiasRestantes = Convert.ToInt32(lector["DiasRestantes"])
                    };
                    listaCaducidad.Add(caducidad);
                }

                lector.Close();
                return listaCaducidad;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos con caducidad: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierra correctamente
                conexion.CerrarConexion(comando.Connection);
            }
        }

    }
}

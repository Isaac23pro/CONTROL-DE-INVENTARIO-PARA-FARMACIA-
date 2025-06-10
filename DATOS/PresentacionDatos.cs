using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using System.Data.SqlClient;

namespace DATOS
{
    public class PresentacionDatos
    {
        private readonly Conexion conexion = new Conexion();
        public List<Presentacion> ObtenerPresentaciones()
        {
            List<Presentacion> presentaciones = new List<Presentacion>();
            using (SqlConnection con = conexion.ObtenerConexion())
            { 
                SqlCommand cmd = new SqlCommand("SELECT * FROM Presentacion", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Presentacion presentacion = new Presentacion
                    {
                        IdPresentacion = Convert.ToInt32(reader["IdPresentacion"]),
                        Descripcion = reader["Descripcion"].ToString(),
                        UnidadMedida = reader["UnidadMedida"].ToString(),
                        CantidadUnidadMedida = Convert.ToInt32(reader["CantidadUnidadMedida"]),
                        
                    };
                
                    presentaciones.Add(presentacion);
                }
            }


            return presentaciones;
        }

        public void EliminarPresentacion(int IdPresentacion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE IdPresentacion = @IdPresentacion", con);
                cmd.Parameters.AddWithValue("@IdPresentacion", IdPresentacion);


                cmd.ExecuteNonQuery();
            }
        }

        public Presentacion ObtenerPresentacionPorId(int id)
        {
            Presentacion presentacion = null;
            
            return presentacion;
        }
    }
}

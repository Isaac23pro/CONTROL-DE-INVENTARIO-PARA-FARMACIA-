using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DATOS;

namespace DATOS
{
    public class ConcentracionDatos
    {
        private Conexion conexion = new Conexion();
        public List<Concentracion> ObtenerConcentraciones()
        {
            List<Concentracion> concentraciones = new List<Concentracion>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Concentracion", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Concentracion concentracion = new Concentracion
                    {
                        IdConcentracion = reader.GetInt32(0),
                        Volumen = reader.GetDecimal(1),
                        Porcentaje = reader.GetDecimal(2)
                    };
                    concentraciones.Add(concentracion);
                }
            }
            return concentraciones;
        }

        public Concentracion ObtenerConcentracionPorId(int idConcentracion)
        {
            Concentracion concentracion = null;
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Concentracion WHERE IdConcentracion = @IdConcentracion", con);
                cmd.Parameters.AddWithValue("@IdConcentracion", idConcentracion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    concentracion = new Concentracion
                    {
                        IdConcentracion = reader.GetInt32(0),
                        Volumen = reader.GetDecimal(1),
                        Porcentaje = reader.GetDecimal(2)
                    };
                }
            }
            return concentracion;
        }

        public void AgregarConcentracion(Concentracion concentracion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Concentracion (Volumen, Porcentaje) VALUES (@Volumen, @Porcentaje)", con);
                cmd.Parameters.AddWithValue("@Volumen", concentracion.Volumen);
                cmd.Parameters.AddWithValue("@Porcentaje", concentracion.Porcentaje);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarConcentracion(Concentracion concentracion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Concentracion SET Volumen = @Volumen, Porcentaje = @Porcentaje WHERE IdConcentracion = @IdConcentracion", con);
                cmd.Parameters.AddWithValue("@IdConcentracion", concentracion.IdConcentracion);
                cmd.Parameters.AddWithValue("@Volumen", concentracion.Volumen);
                cmd.Parameters.AddWithValue("@Porcentaje", concentracion.Porcentaje);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarConcentracion(int idConcentracion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Concentracion WHERE IdConcentracion = @IdConcentracion", con);
                cmd.Parameters.AddWithValue("@IdConcentracion", idConcentracion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

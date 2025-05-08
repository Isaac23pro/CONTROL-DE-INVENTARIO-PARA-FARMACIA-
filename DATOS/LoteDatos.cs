using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS
{
    public class LoteDatos
    {
        private Conexion conexion = new Conexion();
        public List<Lote> ObtenerLotes()
        {
            List<Lote> lotes = new List<Lote>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Lote", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Lote lote = new Lote
                    {
                        IdLote = reader.GetInt32(0),
                        NumeroLote = reader.GetString(1),
                        FechaEntrega = reader.GetDateTime(2),
                    };
                    lotes.Add(lote);
                }
            }
            return lotes;
        }

        public Lote ObtenerLotePorId(int idLote)
        {
            Lote lote = null;
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Lote WHERE IdLote = @IdLote", con);
                cmd.Parameters.AddWithValue("@IdLote", idLote);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lote = new Lote
                    {
                        IdLote = reader.GetInt32(0),
                        NumeroLote = reader.GetString(1),
                        FechaEntrega = reader.GetDateTime(2),
                    };
                }
            }
            return lote;
        }

        public void AgregarLote(Lote lote)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Lote (NumeroLote, FechaEntrega) VALUES (@NumeroLote, @FechaEntrega)", con);
                cmd.Parameters.AddWithValue("@NumeroLote", lote.NumeroLote);
                cmd.Parameters.AddWithValue("@FechaEntrega", lote.FechaEntrega);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarLote(Lote lote)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Lote SET NumeroLote = @NumeroLote, FechaEntrega = @FechaEntrega WHERE IdLote = @IdLote", con);
                cmd.Parameters.AddWithValue("@IdLote", lote.IdLote);
                cmd.Parameters.AddWithValue("@NumeroLote", lote.NumeroLote);
                cmd.Parameters.AddWithValue("@FechaEntrega", lote.FechaEntrega);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarLote(int idLote)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Lote WHERE IdLote = @IdLote", con);
                cmd.Parameters.AddWithValue("@IdLote", idLote);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class CategoriaDatos
    {
        private Conexion conexion = new Conexion();

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM CategoriaFarmaco", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    };
                    categorias.Add(categoria);
                }
            }

            return categorias;
        }

        public Categoria ObtenerCategoriaPorId(int id)
        {
            Categoria categoria = null;

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM CategoriaFarmaco WHERE IdCategoria = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoria = new Categoria
                    {
                        IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    };
                }
            }

            return categoria;
        }

        public void AgregarCategoria(Categoria categoria)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoriaFarmaco (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)", con);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE CategoriFarmaco SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdCategoria = @Id", con);
                cmd.Parameters.AddWithValue("@Id", categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCategoria(int id)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM CategoriaFarmaco WHERE IdCategoria = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}

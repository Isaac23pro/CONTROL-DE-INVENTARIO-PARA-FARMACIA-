using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace DATOS
{
    public class UsuarioDatos
    {
        private Conexion conexion = new Conexion();
        public bool ValidarLogin(string nombreUsuario, string contrasena)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Clave = @Clave";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", contrasena);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void ObtenerUsuarios(List<Usuario> usuarios)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, Nombre, Clave FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.IdUsuario = reader.GetInt32(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Clave = reader.GetString(2);
                        usuarios.Add(usuario);
                    }
                }
            }
        }
    }
}

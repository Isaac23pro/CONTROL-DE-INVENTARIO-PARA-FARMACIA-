using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS
{
    public class ProveedoresDatos
    {
        private readonly Conexion conexion = new Conexion();
        public List<Proveedores> ObtenerProveedores()
        {
            List<Proveedores> proveedores = new List<Proveedores>();
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedor", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proveedores proveedor = new Proveedores
                        {
                            IdProveedor = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Cedula = reader.GetString(2),
                            Correo = reader.GetString(3),
                            IdMarca = reader.GetInt32(4)
                        };
                        proveedores.Add(proveedor);
                    }

                }
                return proveedores;
            }



        }

        public void AgregarProveedor(Proveedores proveedor)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Proveedor (Nombre, Cedula, Correo, IdMarca)" +
                    " VALUES (@Nombre, @Cedula, @Correo, @IdMarca)", con);
                cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                cmd.Parameters.AddWithValue("@Cedula", proveedor.Cedula);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@IdMarca", proveedor.IdMarca);

                cmd.ExecuteNonQuery();
            }

        }

        public void ActualizarProveedor(Proveedores proveedor)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Proveedor SET Nombre = @Nombre, Cedula = @Cedula, Correo = @Correo, IdMarca = @IdMarca WHERE IdProveedor = @IdProveedor", con);
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                cmd.Parameters.AddWithValue("@Cedula", proveedor.Cedula);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@IdMarca", proveedor.IdMarca);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Proveedor WHERE IdProveedor = @IdProveedor", con);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                cmd.ExecuteNonQuery();
            }
        }

       
        
    }
}

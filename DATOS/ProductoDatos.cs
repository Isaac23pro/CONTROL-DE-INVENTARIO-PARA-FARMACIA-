using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace Datalayer
{
    public class ProductoDatos
    {
        private Conexion conexion = new Conexion();

        public List<Producto> ObtenerProducto()
        {
            List<Producto> producto = new List<Producto>();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", con);
                SqlDataReader reader = cmd.ExecuteReader(); 

                while (reader.Read())
                {
                    Producto productos = new Producto
                    {
                        IdProducto = reader.GetInt32(0),
                        NombreComercial = reader.GetString(1),
                        NombreGenerico = reader.GetString(2),
                        IdCategoria = reader.GetInt32(3),
                        PrecioVenta = reader.GetDecimal(4),
                        PrecioCompra = reader.GetDecimal(5),                       
                        IdPresentacion = reader.GetInt32(6),                   
                        IdConcentracion = reader.GetInt32(7),
                        IdProveedor = reader.GetInt32(8),
                        IdLote = reader.GetInt32(9),
                        


                    };

                    producto.Add(productos);
                }
            }

            return producto;
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            Producto producto = null;

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE IdProducto = @IdProducto", con);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto
                    {
                        IdProducto = reader.GetInt32(0),
                        NombreComercial = reader.GetString(1),
                        NombreGenerico = reader.GetString(2),
                        IdCategoria = reader.GetInt32(3),
                        PrecioVenta = reader.GetDecimal(4),
                        PrecioCompra = reader.GetDecimal(5),
                        IdPresentacion = reader.GetInt32(6),
                        IdConcentracion = reader.GetInt32(7),
                        IdProveedor = reader.GetInt32(8),
                        IdLote = reader.GetInt32(9),

                    };

                }
            }

            return producto;
        }

        public void AgregarProducto(Producto producto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Productos (NombreComercial, NombreGenerico, PrecioCompra, PrecioVenta, IdPresentacion, IdLote, IdConcentracion, IdCategoria, IdProveedor) " +
                    "VALUES (@NombreComercial, @NombreGenerico, @PrecioCompra, @PrecioVenta, @IdPresentacion, @IdLote, @IdConcentracion, @IdCategoria, @IdProveedor)", con);

                cmd.Parameters.AddWithValue("@NombreComercial", producto.NombreComercial);
                cmd.Parameters.AddWithValue("@NombreGenerico", producto.NombreGenerico);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@IdPresentacion", producto.IdPresentacion);
                cmd.Parameters.AddWithValue("@IdLote", producto.IdLote);
                cmd.Parameters.AddWithValue("@IdConcentracion", producto.IdConcentracion);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor);
                    
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Productos SET NombreComercial = @NombreComercial, NombreGenerico = @NombreGenerico, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, IdPresentacion = @IdPresentacion, IdLote = @IdLote, IdConcentracion = @IdConcentracion, IdCategoria = @IdCategoria, IdProveedor = @IdProveedor " +
                    "WHERE IdProducto = @IdProducto", con);

                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@NombreComercial", producto.NombreComercial);
                cmd.Parameters.AddWithValue("@NombreGenerico", producto.NombreGenerico);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@IdPresentacion", producto.IdPresentacion);
                cmd.Parameters.AddWithValue("@IdLote", producto.IdLote);
                cmd.Parameters.AddWithValue("@IdConcentracion", producto.IdConcentracion);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor);

                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE IdProducto = @IdProducto", con);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

             
                cmd.ExecuteNonQuery();
            }
        }

        
        public List<Producto> ObtenerProductoPorCategoria(int idCategoria)
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE IdCategoria = @IdCategoria", con);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto
                    {
                        IdProducto = reader.GetInt32(0),
                        NombreComercial = reader.GetString(1),
                        NombreGenerico = reader.GetString(2),
                        IdCategoria = reader.GetInt32(3),
                        PrecioVenta = reader.GetDecimal(4),
                        PrecioCompra = reader.GetDecimal(5),
                        IdPresentacion = reader.GetInt32(6),
                        IdConcentracion = reader.GetInt32(7),
                        IdProveedor = reader.GetInt32(8),
                        IdLote = reader.GetInt32(9),
                    };

                    productos.Add(producto);
                }
            }

            return productos;
        }

        public List<Producto> BuscarPorNombre(string nombreParcial)
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Producto WHERE NombreGenerico LIKE @NombreGenerico";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NombreGenerico", "%" + nombreParcial + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto
                    {
                        IdProducto = reader.GetInt32(0),
                        NombreComercial = reader.GetString(1),
                        NombreGenerico = reader.GetString(2),
                        IdCategoria = reader.GetInt32(3),
                        PrecioVenta = reader.GetDecimal(4),
                        PrecioCompra = reader.GetDecimal(5),
                        IdPresentacion = reader.GetInt32(6),
                        IdConcentracion = reader.GetInt32(7),
                        IdProveedor = reader.GetInt32(8),
                        IdLote = reader.GetInt32(9),
                    };
                    lista.Add(producto);
                }
            }

            return lista;
        }




    }
}


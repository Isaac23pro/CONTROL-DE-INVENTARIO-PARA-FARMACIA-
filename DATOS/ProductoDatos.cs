using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS
{
    public class ProductoDatos
    {
        private Conexion conexion = new Conexion();

        public List<LaboratorioProducto> ObtenerProductos()
        {
            List<LaboratorioProducto> producto = new List<LaboratorioProducto>();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM laboratorios_producto", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LaboratorioProducto productos = new LaboratorioProducto
                    {
                        id_laboratorio_producto = Convert.ToInt32(reader["id_laboratorio_producto"]),
                        nombre_comercial = reader["nombre_comercial"].ToString(),
                        nombre_generico = reader["nombre_generico"].ToString(),
                        id_categoria_farmaco = Convert.ToInt32(reader["id_categoria_farmaco"]),
                        precio_venta = Convert.ToDecimal(reader["precio_venta"]),
                        precio_compra = Convert.ToDecimal(reader["precio_compra"]),
                        id_presentacion = Convert.ToInt32(reader["id_presentacion"]),
                        id_concentracion = Convert.ToInt32(reader["id_concentracion"]),
                        id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                        id_lote = Convert.ToInt32(reader["id_lote"]),
                    };

                    producto.Add(productos);
                }
            }

            return producto;
        }

        public LaboratorioProducto ObtenerProductoPorId(int idProducto)
        {
             LaboratorioProducto producto = null;

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE IdProducto = @IdProducto", con);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    producto = new LaboratorioProducto
                    {
                        id_laboratorio_producto = Convert.ToInt32(reader["id_laboratorio_producto"]),
                        nombre_comercial = reader["nombre_comercial"].ToString(),
                        nombre_generico = reader["nombre_generico"].ToString(),
                        id_categoria_farmaco = Convert.ToInt32(reader["id_categoria_farmaco"]),
                        precio_venta = Convert.ToDecimal(reader["precio_venta"]),
                        precio_compra = Convert.ToDecimal(reader["precio_compra"]),
                        id_presentacion = Convert.ToInt32(reader["id_presentacion"]),
                        id_concentracion = Convert.ToInt32(reader["id_concentracion"]),
                        id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                        id_lote = Convert.ToInt32(reader["id_lote"]),
                    };
                

                }
            }

            return producto;
        }

        public void AgregarProducto(LaboratorioProducto producto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO laboratorios_producto (nombre_comercial, nombre_generico, id_categoria_farmaco, precio_venta, precio_compra, id_presentacion, id_concentracion, id_proveedor, id_lote) " +
                    "VALUES (@nombre_comercial, @nombre_generico, @id_categoria_farmaco, @precio_venta, @precio_compra, @id_presentacion, @id_concentracion, @id_proveedor, @id_lote)", con);

                cmd.Parameters.AddWithValue("@nombre_comercial", producto.nombre_comercial);
                cmd.Parameters.AddWithValue("@nombre_generico", producto.nombre_generico);
                cmd.Parameters.AddWithValue("@id_categoria_farmaco", producto.id_categoria_farmaco);
                cmd.Parameters.AddWithValue("@precio_venta", producto.precio_venta);
                cmd.Parameters.AddWithValue("@precio_compra", producto.precio_compra);
                cmd.Parameters.AddWithValue("@id_presentacion", producto.id_presentacion);
                cmd.Parameters.AddWithValue("@id_concentracion", producto.id_concentracion);
                cmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor);
                cmd.Parameters.AddWithValue("@id_lote", producto.id_lote);

                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarProducto(LaboratorioProducto producto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE laboratorios_producto SET nombre_comercial = @nombre_comercial, nombre_generico = @nombre_generico, id_categoria_farmaco = @id_categoria_farmaco, precio_venta = @precio_venta, precio_compra = @precio_compra, id_presentacion = @id_presentacion, id_concentracion = @id_concentracion, id_proveedor = @id_proveedor, id_lote = @id_lote WHERE id_laboratorio_producto = @id_laboratorio_producto", con);
                cmd.Parameters.AddWithValue("@id_laboratorio_producto", producto.id_laboratorio_producto);
                cmd.Parameters.AddWithValue("@nombre_comercial", producto.nombre_comercial);
                cmd.Parameters.AddWithValue("@nombre_generico", producto.nombre_generico);
                cmd.Parameters.AddWithValue("@id_categoria_farmaco", producto.id_categoria_farmaco);
                cmd.Parameters.AddWithValue("@precio_venta", producto.precio_venta);
                cmd.Parameters.AddWithValue("@precio_compra", producto.precio_compra);
                cmd.Parameters.AddWithValue("@id_presentacion", producto.id_presentacion);
                cmd.Parameters.AddWithValue("@id_concentracion", producto.id_concentracion);
                cmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor);
                cmd.Parameters.AddWithValue("@id_lote", producto.id_lote);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM laboratorios_producto WHERE id_laboratorio_producto = @id_laboratorio_producto", con);
                cmd.Parameters.AddWithValue("@id_laboratorio_producto", idProducto);
                cmd.ExecuteNonQuery();
            }
        }
    }

    
}

  

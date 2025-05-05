using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using DATOS;

namespace NEGOCIO
{
    public class ProductoNegocio
    {
        private ProductoDatos productoDatos = new ProductoDatos();


        public List<Producto> ObtenerProductos()
        {
            return productoDatos.ObtenerProductos();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            return productoDatos.ObtenerProductoPorId(idProducto);
        }

        public void AgregarProducto(Producto producto)
        {
            productoDatos.AgregarProducto(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            productoDatos.ActualizarProducto(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            productoDatos.EliminarProducto(idProducto);
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            return productoDatos.BuscarPorNombre(nombre);
        }
    }
}

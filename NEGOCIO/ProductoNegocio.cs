using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace NEGOCIO
{
    public class ProductoNegocio
    {
        private ProductoDatos productoDatos = new ProductoDatos();


        public List<LaboratorioProducto> ObtenerProductos()
        {
            return productoDatos.ObtenerProductos();
        }

        public LaboratorioProducto ObtenerProductoPorId(int idProducto)
        {
            return productoDatos.ObtenerProductoPorId(idProducto);
        }

        public void AgregarProducto(LaboratorioProducto producto)
        {
            productoDatos.AgregarProducto(producto);
        }

        public void ActualizarProducto(LaboratorioProducto producto)
        {
            productoDatos.ActualizarProducto(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            productoDatos.EliminarProducto(idProducto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreComercial { get; set; }
        public string NombreGenerico { get; set; }
        public int IdCategoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdPresentacion { get; set; }
        public int IdLote { get; set; }
        public int IdConcentracion { get; set; }
        
        public int IdProveedor { get; set; }
      
       
        


        public Producto() { }
        public Producto(int idproducto, string nombrecomercial, string nombregenerico, decimal preciocompra,
            decimal precioventa, int idpresentacion, int idlote, int idconcentracion, int idcategoria, int idproveedor)
        {
            IdProducto = idproducto;
            NombreComercial = nombrecomercial;
            NombreGenerico = nombregenerico;
            PrecioCompra = preciocompra;
            PrecioVenta = precioventa;
            IdPresentacion = idpresentacion;
            IdLote = idlote;
            IdConcentracion = idconcentracion;
            IdCategoria = idcategoria;
            IdProveedor = idproveedor;

        }
    }
}

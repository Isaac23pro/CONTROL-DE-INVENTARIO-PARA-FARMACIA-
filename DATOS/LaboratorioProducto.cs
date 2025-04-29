using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
     public class LaboratorioProducto
    {
        public int id_laboratorio_producto { get; set; }
        public string nombre_comercial { get; set; }
        public string nombre_generico { get; set; }
        public int id_categoria_farmaco { get; set; }
        public decimal precio_venta { get; set; }
        public decimal precio_compra { get; set; }
        public int id_presentacion { get; set; }
        public int id_concentracion { get; set; }
        public int id_proveedor { get; set; }
        public int id_lote { get; set; }

        public LaboratorioProducto() { }

        public LaboratorioProducto(int idLaboratorioProducto, string nombreComercial, string nombreGenerico, int idCategoriaFarmaco, decimal precioVenta, decimal precioCompra, int idPresentacion, int idConcentracion, int idProveedor, int idLote)
        {
            id_laboratorio_producto = idLaboratorioProducto;
            nombre_comercial     = nombreComercial;
            nombre_generico = nombreGenerico;
            id_categoria_farmaco = idCategoriaFarmaco;
            precio_venta = precioVenta;
            precio_compra = precioCompra;
            id_presentacion = idPresentacion;
            id_concentracion = idConcentracion;
            id_proveedor = idProveedor;
            id_lote = idLote;
        }
    }

}

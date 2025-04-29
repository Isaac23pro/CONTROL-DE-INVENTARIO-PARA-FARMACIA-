using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class MovimientoInventario
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }

        public MovimientoInventario() { }

        public MovimientoInventario(int idMovimiento, int idProducto, string tipoMovimiento, int cantidad, decimal precioUnitario, DateTime fechaMovimiento, string referencia, string observaciones)
        {
            IdMovimiento = idMovimiento;
            IdProducto = idProducto;
            TipoMovimiento = tipoMovimiento;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            FechaMovimiento = fechaMovimiento;
            Referencia = referencia;
            Observaciones = observaciones;
        }
    }
}

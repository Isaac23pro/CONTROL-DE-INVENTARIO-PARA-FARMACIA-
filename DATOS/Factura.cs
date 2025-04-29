using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    internal class Factura
    {
       
            public int IdFactura { get; set; }
            public int IdCliente { get; set; }
            public DateTime Fecha { get; set; }
            public decimal Total { get; set; }

            public Factura() { }

            public Factura(int idFactura, int idCliente, DateTime fecha, decimal total)
            {
                IdFactura = idFactura;
                IdCliente = idCliente;
                Fecha = fecha;
                Total = total;
            }
        

    }
}

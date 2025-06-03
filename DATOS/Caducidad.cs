using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Caducidad
    {
        public int IdCaducidad { get; set; }
        public int IdProducto { get; set; }
        public int IdLote { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public int DiasRestantes { get; set; }

    }
}

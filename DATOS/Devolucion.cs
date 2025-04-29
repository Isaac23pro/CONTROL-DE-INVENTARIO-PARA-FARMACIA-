using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Devolucion
    {
        public int IdDevolucion { get; set; }
        public string TipoDevolucion { get; set; }
        public string PoliticaDevolucion { get; set; }
        public int IdFactura { get; set; }
        public int IdLaboratorioProducto { get; set; }

        public Devolucion() { }

        public Devolucion(int idDevolucion, string tipoDevolucion, string politicaDevolucion, int idFactura, int idLaboratorioProducto)
        {
            IdDevolucion = idDevolucion;
            TipoDevolucion = tipoDevolucion;
            PoliticaDevolucion = politicaDevolucion;
            IdFactura = idFactura;
            IdLaboratorioProducto = idLaboratorioProducto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Lote
    {
        public int IdLote { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaEntrega { get; set; }

        public Lote() { }

        public Lote(int idLote, string numeroLote, DateTime fechaEntrega)
        {
            IdLote = idLote;
            NumeroLote = numeroLote;
            FechaEntrega = fechaEntrega;
        }
    }

}

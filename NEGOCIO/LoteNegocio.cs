using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NEGOCIO
{
    public class LoteNegocio
    {
        private DATOS.LoteDatos loteDatos = new DATOS.LoteDatos();

        public List<DATOS.Lote> ObtenerLotes()
        {
            return loteDatos.ObtenerLotes();
        }

    }
}

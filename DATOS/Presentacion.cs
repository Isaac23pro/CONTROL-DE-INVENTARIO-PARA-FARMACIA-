using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Presentacion
    {
        public int IdPresentacion { get; set; }
        public string DescripcionPresentacion { get; set; }
        public string UnidadMedida { get; set; }
        public int CantidadUnidadMedida { get; set; }

        public Presentacion() { }

        public Presentacion(int idPresentacion, string descripcionPresentacion, string unidadMedida, int cantidadUnidadMedida)
        {
            IdPresentacion = idPresentacion;
            DescripcionPresentacion = descripcionPresentacion;
            UnidadMedida = unidadMedida;
            CantidadUnidadMedida = cantidadUnidadMedida;
        }
    }

}

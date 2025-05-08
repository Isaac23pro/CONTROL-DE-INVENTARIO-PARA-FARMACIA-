using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Concentracion
    {
        public int IdConcentracion { get; set; }
        public decimal Volumen { get; set; }
        public decimal Porcentaje { get; set; }

        public string VolumenFormateado => Volumen.ToString("0.##");

        public Concentracion() { }

        public Concentracion(int idConcentracion, decimal volumen, decimal porcentaje)
        {
            IdConcentracion = idConcentracion;
            Volumen = volumen;
            Porcentaje = porcentaje;
        }
    }
}

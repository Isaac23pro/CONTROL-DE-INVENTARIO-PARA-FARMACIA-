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
        public string Valor { get; set; }

        public Concentracion() { }

        public Concentracion(int idConcentracion, string valor)
        {
            IdConcentracion = idConcentracion;
            Valor = valor;
        }
    }


}

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
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public int CantidadUnidadMedida { get; set; }
        public string Nombre { get; set; }

        public Presentacion () { }

        public Presentacion(int idPresentacion, string descripcion, string unidadMedida, int cantidadUnidadMedida, string nombre)
        {
            IdPresentacion = idPresentacion;
            Descripcion = descripcion;
            UnidadMedida = unidadMedida;
            CantidadUnidadMedida = cantidadUnidadMedida;
            Nombre = nombre;
        }
    }
}

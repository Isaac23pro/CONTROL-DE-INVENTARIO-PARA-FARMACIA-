using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class ConcentracionNegocio
    {
        private DATOS.ConcentracionDatos concentracionDatos = new DATOS.ConcentracionDatos();
        public List<DATOS.Concentracion> ObtenerConcentraciones()
        {
            return concentracionDatos.ObtenerConcentraciones();
        }
        public DATOS.Concentracion ObtenerConcentracionPorId(int idConcentracion)
        {
            return concentracionDatos.ObtenerConcentracionPorId(idConcentracion);
        }
        public void AgregarConcentracion(DATOS.Concentracion concentracion)
        {
            concentracionDatos.AgregarConcentracion(concentracion);
        }
        public void ActualizarConcentracion(DATOS.Concentracion concentracion)
        {
            concentracionDatos.ActualizarConcentracion(concentracion);
        }
        public void EliminarConcentracion(int idConcentracion)
        {
            concentracionDatos.EliminarConcentracion(idConcentracion);
        }
    }
}

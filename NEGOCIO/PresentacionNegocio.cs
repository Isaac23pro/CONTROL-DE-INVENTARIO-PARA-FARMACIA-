using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace NEGOCIO
{
    public class PresentacionNegocio
    {
        private readonly PresentacionDatos presentacionDatos = new PresentacionDatos();
        public List<Presentacion> ObtenerPresentaciones()
        {
            return presentacionDatos.ObtenerPresentaciones();
        }
        public Presentacion ObtenerPresentacionPorId(int id)
        {
            return presentacionDatos.ObtenerPresentacionPorId(id);
        }
    }
}

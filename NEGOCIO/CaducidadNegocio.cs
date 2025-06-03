using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace NEGOCIO
{
    public class CaducidadNegocio
    {


        private CaducidadDatos caducidadDatos;

        public CaducidadNegocio()
        {
            caducidadDatos = new CaducidadDatos();
        }

        public List<Caducidad> ObtenerProductosCaducidad()
        {
            try
            {
                return caducidadDatos.ObtenerProductosCaducidad();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message);
            }
        }

    }
}


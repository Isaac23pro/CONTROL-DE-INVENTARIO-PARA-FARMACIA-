using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class CategoriaNegocio
    {
        private DATOS.CategoriaDatos datos = new DATOS.CategoriaDatos();

        public List<DATOS.Categoria> ObtenerCategorias()
        {
            return datos.ObtenerCategorias();
        }

        


    }
}

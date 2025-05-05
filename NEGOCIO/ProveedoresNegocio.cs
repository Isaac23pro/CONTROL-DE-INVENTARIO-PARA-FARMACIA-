using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using DATOS;

namespace NEGOCIO
{
    public class ProveedoresNegocio
    {
        private readonly ProveedoresDatos proveedoresDatos = new ProveedoresDatos();
        public List<Proveedores> ObtenerProveedores()
        {
            return proveedoresDatos.ObtenerProveedores();
        }
       
        
    }
}

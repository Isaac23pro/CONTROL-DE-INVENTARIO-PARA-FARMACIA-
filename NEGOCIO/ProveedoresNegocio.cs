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

        public void AgregarProveedor(Proveedores proveedor)
        {
            proveedoresDatos.AgregarProveedor(proveedor);
        }

        public void EliminarProveedor(int idProveedor)
        {
            proveedoresDatos.EliminarProveedor(idProveedor);
        }

        public void ActualizarProveedor(Proveedores proveedor)
        {
            proveedoresDatos.ActualizarProveedor(proveedor);
        }
        public Proveedores ObtenerProveedorPorId(int idProveedor)
        {
            return proveedoresDatos.ObtenerProveedores().FirstOrDefault(p => p.IdProveedor == idProveedor);
        }


        
        
    }
}

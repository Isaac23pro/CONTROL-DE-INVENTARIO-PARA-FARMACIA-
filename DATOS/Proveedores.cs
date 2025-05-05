using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Proveedores
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public int IdMarca { get; set; }

        public Proveedores() { }

        public Proveedores(int idProveedor, string nombre, string cedula, string correo, int idMarca)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Cedula = cedula;
            Correo = correo;
            IdMarca = idMarca;
        }
    }
}

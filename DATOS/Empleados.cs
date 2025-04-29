using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Empleados
    {
        public int id_empleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string cedula { get; set; }

        public Empleados(int id_empleado, string nombres, string apellidos, string telefono, string correo, string cedula)
        {
            this.id_empleado = id_empleado;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.correo = correo;
            this.cedula = cedula;
        }

        public Empleados() { }
    }
}

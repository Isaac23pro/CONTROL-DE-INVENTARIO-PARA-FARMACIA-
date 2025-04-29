using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public  class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string Cargo { get; set; }
        public string Clave { get; set; }



        public Usuarios(int id_usuario, string nombre, string apellido, string Cargo, string clave)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.Cargo = Cargo;
            this.Clave = clave;
        }

            public Usuarios() { }

    }
    
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Cedula { get; set; }

        public Usuario(string nombre, string apellido, string clave, string correo, string cedula)
        {
            Nombre = nombre;
            Apellido = apellido;
            Clave = clave;
            Correo = correo;
            Cedula = cedula;
        }

        public Usuario() { }
    }
}

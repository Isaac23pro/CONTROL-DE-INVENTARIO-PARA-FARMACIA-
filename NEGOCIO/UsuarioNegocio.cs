using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using DATOS;

namespace NEGOCIO
{
    public class UsuarioNegocio
    {
        private UsuarioDatos datos = new UsuarioDatos();

        public bool ValidarLogin(string nombreUsuario, string contrasena)
        {
           
            return datos.ValidarLogin(nombreUsuario, contrasena);
        }
    }
}

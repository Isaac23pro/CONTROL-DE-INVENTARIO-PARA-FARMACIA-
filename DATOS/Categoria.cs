﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Categoria
    {
        
         public int IdCategoria { get; set; }
         public string Nombre { get; set; }
         public string Descripcion { get; set; }

        public Categoria() { }

        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }
       

    }
}

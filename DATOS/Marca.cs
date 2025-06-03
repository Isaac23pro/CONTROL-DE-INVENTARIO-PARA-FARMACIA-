using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string PoliticaDevolucion { get; set; }


    public Marca() { }
    public Marca(int idMarca, string nombre, string descripcion, string politicaDevolucion)
        {
            IdMarca = idMarca;
            Nombre = nombre;
            Descripcion = descripcion;
            PoliticaDevolucion = politicaDevolucion;
        }


    }
}

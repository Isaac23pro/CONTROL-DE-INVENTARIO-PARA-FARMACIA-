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
        public string NombreMarca { get; set; }
        public string PoliticaDevolucion { get; set; }

        public Marca() { }

        public Marca(int idMarca, string nombreMarca, string politicaDevolucion)
        {
            IdMarca = idMarca;
            NombreMarca = nombreMarca;
            PoliticaDevolucion = politicaDevolucion;
        }
    }

}

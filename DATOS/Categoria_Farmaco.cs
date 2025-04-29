using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Categoria_Farmaco
    {
        public int IdCategoriaFarmaco { get; set; }
        public string NombreCategoriaFarmaco { get; set; }
        public string DescripcionCategoriaFarmaco { get; set; }
        public int IdMedida { get; set; }

        public Categoria_Farmaco() { }

        public Categoria_Farmaco(int idCategoriaFarmaco, string nombreCategoriaFarmaco, string descripcionCategoriaFarmaco, int idMedida)
        {
            IdCategoriaFarmaco = idCategoriaFarmaco;
            NombreCategoriaFarmaco = nombreCategoriaFarmaco;
            DescripcionCategoriaFarmaco = descripcionCategoriaFarmaco;
            IdMedida = idMedida;
        }
    }
}

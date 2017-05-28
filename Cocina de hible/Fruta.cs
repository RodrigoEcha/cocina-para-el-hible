using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Fruta : Ingrediente
    {
        public bool cascara = true;
        public int semilla = 10;
        public bool cortado = false;
        public enum Tipo {

            Platano,
            Manzana,
            Naranja,
            Sandia

        }
    }
}

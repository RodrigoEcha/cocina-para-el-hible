using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Liquido : Ingrediente
    {
        public enum Sabor 
        {
            Salado,
            Agrio,
            Insaboro

        }
        public enum Tipo { 
            Agua,
            Aceite,
            Vinagre
        }
    }
}

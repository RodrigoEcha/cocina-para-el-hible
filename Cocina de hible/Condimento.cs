using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Condimento : Ingrediente
    {
        public bool sasonar = false;
        public int usosRestantes = 4;
        public enum Sabor {
            Dulce,
            Salado,
            Picante

        }

        public enum tipo {
                Azucar,
                Sal,
                Cuarri


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Verdura : Ingrediente
    {
        public bool cortado = false;
        public enum Tipo {
            Apio,
            Esparrago,
            Espinaca,
            Lechuga

        }
    }
}

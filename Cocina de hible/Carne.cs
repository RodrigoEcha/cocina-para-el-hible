using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Carne : Ingrediente
    {
        public bool cortado = false;
        public int peso = 30;
        public enum Estado  {
          Crudo,
          TerminoMedio,
          BienCocido,
        }

        public enum Tipo {
                Vacuno,
                Pollo,
                Pezcado


        }
  }
}

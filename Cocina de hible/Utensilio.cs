using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Utensilio : Herramienta
    {
        public string Nombre;
        public int usosRestantes = 5;

        public enum Material {
            Madera,
            Metal,
            Plastico
        }
        public Material material = Material.Madera;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina_de_hible
{
    class Fuente : Herramienta
    {
        public int cantidad = 10;
        public int capacidad = 0;

        public enum Tipo {
            Taper,
            Plato
        }
        public Tipo tipo = Tipo.Taper;

        public void Agregar(Ingrediente ingrediente, int cantidad)
        {
           
        }

        public Ingrediente Quitar(Ingrediente ingrediente)
        {
            return null;
        }
    }
}

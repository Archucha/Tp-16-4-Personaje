using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    public abstract class Equipo: Item, IEquipar
    {
        public bool Equipado { get; set; }
        public abstract void Equipar(Personaje pj);
        public abstract void Desequipar(Personaje pj);

    }
}

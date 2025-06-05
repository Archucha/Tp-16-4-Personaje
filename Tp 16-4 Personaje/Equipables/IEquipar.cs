using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    internal interface IEquipar
    { 
        public void Equipar(Personaje pj);
        public void Desequipar(Personaje pj);
    }
}

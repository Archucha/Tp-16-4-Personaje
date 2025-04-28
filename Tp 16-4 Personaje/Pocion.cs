using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    public abstract class Pocion:Personaje
    {
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        int Cura { get; set; }
        public abstract int Usar(Personaje pj);
    }
}

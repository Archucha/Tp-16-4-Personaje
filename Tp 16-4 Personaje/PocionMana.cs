using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    internal class PocionMana:Pocion
    {
        public override int Usar(Personaje pj)
        {
            Random Al = new Random();
            int NumAl = Al.Next(Minimo, Maximo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    public class PocionMana:Pocion
    {
        public override int Usar(Personaje pj)
        {
            Random Al = new Random();
            int NumAl = Al.Next(Minimo, Maximo);
            int Mana = pj.Mana;
            pj.Mana = pj.Mana + NumAl;
            if (pj.Mana > pj.ManaTotal)
            {
                pj.Mana = pj.ManaTotal;
            }
            ManaRest = pj.Mana - Mana;
            return ManaRest;
        }
    }
}

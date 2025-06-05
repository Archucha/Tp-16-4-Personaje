using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Pociones
{
    public class PocionVida:Pocion
    {
        public override int Usar(Personaje pj)
        {
            Random Al = new Random();
            int NumAl = Al.Next(Minimo, Maximo);
            int Vida = pj.Vida;
            pj.Vida = pj.Vida + NumAl;
            if (pj.Vida > pj.VidaTotal)
            {
                pj.Vida = pj.VidaTotal;
            }
            Restauro = pj.Vida - Vida;
            return Restauro;
        }

        public override string ToString()
        {
            return "Pocion de Vida";
        }
    }
}

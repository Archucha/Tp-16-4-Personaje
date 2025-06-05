using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    internal class Pechera:Equipo
    {
        public int Defensa = 15;
        public int Vida = 20;
        public override void Equipar(Personaje pj)
        {
            pj.Defensa = pj.Defensa + Defensa;
            pj.Vida = pj.Vida + Vida;
            pj.VidaTotal = pj.VidaTotal + Vida;
            Equipado = true;
        }
        public override void Desequipar(Personaje pj)
        {
            pj.Defensa = pj.Defensa - Defensa;
            pj.Vida = pj.Vida - Vida;
            pj.VidaTotal = pj.VidaTotal - Vida;
            Equipado = false;
        }
        public override string ToString()
        {
            if (Equipado == true)
            {
                return "Pechera (Equipado)";
            }
            else
            {
                return "Pechera";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    public class Casco : Equipo
    {
        public int Defensa = 10;
        public int Mana = 5;
        public override void Equipar(Personaje pj)
        {
            if (Equipado == false)
            {
                pj.Defensa = pj.Defensa + Defensa;
                pj.Mana = pj.Mana + Mana;
                pj.ManaTotal = pj.ManaTotal + Mana;
                Equipado = true;
            }
        }
        public override void Desequipar(Personaje pj)
        {
            if (Equipado == true)
            {
                pj.Defensa = pj.Defensa - Defensa;
                pj.Mana = pj.Mana - Mana;
                pj.ManaTotal = pj.ManaTotal - Mana;
                Equipado = false;
            }
        }

        public override string ToString()
        {
            if (Equipado == true)
            {
                return "Casco (Equipado)";
            }
            else
            {
                return "Casco";
            }
        }
    }
}

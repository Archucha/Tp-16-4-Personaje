using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    internal class Espada:Equipo
    {
        public int Fuerza = 10;
        public override void Equipar(Personaje pj)
        {
            if (Equipado == false)
            {
                pj.Fuerza = pj.Fuerza + Fuerza;
                Equipado = true;
            }
        }
        public override void Desequipar(Personaje pj)
        {
            if (Equipado == true)
            {
                pj.Fuerza = pj.Fuerza - Fuerza;
                Equipado = false;
            }
        }
        public override string ToString()
        {
            if (Equipado == true)
            {
                return "Espada (Equipada)";
            }
            else
            {
                return "Espada";
            }
        }
    }
}

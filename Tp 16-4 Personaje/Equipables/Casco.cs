using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    internal class Casco : Equipo
    {
        public bool Equipado = false;
        public int Defensa = 10;
        public int Mana = 5;
        public override void Equipar(Personaje pj)
        {
            if (Equipado = false)
            {
                pj.Defensa = pj.Defensa + Defensa;
                pj.Mana = pj.Mana + Mana;
                pj.ManaTotal = pj.ManaTotal + Mana;
                Console.WriteLine("El objeto fue equipado");
                Equipado = true;
            }
            else
            {
                Console.WriteLine("El objeto ya esta equipado");
            }
        }
        public override void Desequipar(Personaje pj)
        {
            if (Equipado = true)
            {
                pj.Defensa = pj.Defensa - Defensa;
                pj.Mana = pj.Mana - Mana;
                pj.ManaTotal = pj.ManaTotal - Mana;
                Console.WriteLine("El objeto fue equipado");
                Equipado = false;
            }
            else
            {
                Console.WriteLine("El objeto no esta equipado");
            }
        }
    }
}

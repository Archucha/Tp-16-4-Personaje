using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje.Equipables
{
    internal class Pechera:Equipo
    {
        public bool Equipado = false;
        public int Defensa = 15;
        public int Vida = 20;
        public override void Equipar(Personaje pj)
        {
            if (Equipado = false)
            {
                pj.Defensa = pj.Defensa + Defensa;
                pj.Vida = pj.Vida + Vida;
                pj.VidaTotal = pj.VidaTotal + Vida;
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
            if (Equipado = false)
            {
                pj.Defensa = pj.Defensa - Defensa;
                pj.Vida = pj.Vida - Vida;
                pj.VidaTotal = pj.VidaTotal - Vida;
                Console.WriteLine("El objeto fue equipado");
                Equipado = true;
            }
            else
            {
                Console.WriteLine("El objeto ya esta equipado");
            }
        }
    }
}

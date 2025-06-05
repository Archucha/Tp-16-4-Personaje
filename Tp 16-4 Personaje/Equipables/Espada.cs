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
            if (Equipado == true)
            {
                pj.Fuerza = pj.Fuerza - Fuerza;
                Console.WriteLine("El objeto fue desequipado");
                Equipado = false;
            }
            else
            {
                Console.WriteLine("El objeto no esta equipado");
            }
        }
    }
}

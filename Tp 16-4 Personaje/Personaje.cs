using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    public class Personaje
    {
        public string? Color  { get; set; }
        public int Vida { get; set; }
        public int VidaTotal { get; set; }
        public int ManaTotal { get; set; }
        public int Mana { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Daño { get; set; }  
        public Inventario inventario { get; set; }
        public void CambiarColor(string? Ncolor)
        {
            Color = Ncolor;
        }
        public int RecibirDaño(int DañoRec)
        {
            int DañoEf = DañoRec - Defensa;
            if (DañoEf  < 0)
            {
                DañoEf = 0;
            }
            Vida = Vida - DañoEf;
            return DañoEf;
        }
        public int Atacar(Personaje Objetivo)
        {
            if (Mana != 0)
            {
                Objetivo.RecibirDaño(Fuerza);
                Mana = Mana - 1;
            }
            else
            {
                Daño = 0;
            }
            return Daño;
        }

    }
}

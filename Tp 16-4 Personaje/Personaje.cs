using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    internal class Personaje
    {
        public string Color { get; set; }
        public int Vida { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Mana { get; set; }    
        public int Daño { get; set; }  
        
        public void Carga()
        {
            Console.WriteLine("Ingrese el color");
            Color = Console.ReadLine(); 
            Console.WriteLine("Ingrese la vida del personaje");
            Vida = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la defensa del personaje");
            Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fuerza del personaje");
            Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mana del personaje");
            Mana = int.Parse(Console.ReadLine());
        }
        public void CambiarColor(string Ncolor)
        {
            Console.WriteLine("Ingrese el nuevo color que desea");
            Color = Ncolor;
        }
        public int RecibirDaño(int DañoRecibido)
        {
            DañoRecibido = Daño;
            int DañoEf = DañoRecibido - Defensa;
            if (DañoEf  < 0)
            {
                DañoEf = 0;
            }
            Vida = Vida - DañoEf;
            return DañoEf;
            Console.WriteLine("Recibiste: " + DañoEf + " puntos de daño");
        }
        public int Atacar(Personaje Objetivo)
        {
            if (Mana != 0)
            {
                Objetivo.RecibirDaño(Daño = Fuerza);
                Mana = Mana - 1;
                
            }
            else
            {
                Daño = 0;
            }
            return Daño;
        }
        public void Muestra()
        {
            Console.WriteLine("========Datos========");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Vida: " + Vida);
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("=====Estadisticas=====");
            Console.WriteLine("Fuerza: " + Fuerza);
            Console.WriteLine("Defensa: " + Defensa);
        }
    }
}

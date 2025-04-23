using System.Drawing;
using Tp_16_4_Personaje;
internal class Program
{
        public static void Carga(Personaje p)
    {
        Console.WriteLine("Ingrese el color");
        p.Color = Console.ReadLine();
        Console.WriteLine("Ingrese la vida del personaje");
        p.Vida = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la defensa del personaje");
        p.Defensa = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la fuerza del personaje");
        p.Fuerza = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el mana del personaje");
        p.Mana = int.Parse(Console.ReadLine());
    }
    public static void Muestra(Personaje p)
    {
        Console.WriteLine("========Datos========");           
        Console.WriteLine("Color: " + p.Color);
        Console.WriteLine("Vida: " + p.Vida);
        Console.WriteLine("Mana: " + p.Mana);        
    }
    private static void Main(string[] args)
    {
        Personaje p1 = new Personaje();
        Personaje p2 = new Personaje();

        Console.WriteLine("Carga personaje 1");
        Carga(p1);
        Console.WriteLine("Carga personaje 2");
        Carga(p2);
        do
        {
            Console.WriteLine("Ingrese su accion");
            Console.WriteLine("1: Cambiar color");
            Console.WriteLine("2: Atacar");
            Console.WriteLine("3: Recibir daño");
            int sel = int.Parse(Console.ReadLine());
            switch(sel)
            {
                case 1:
                    Console.WriteLine("Ingrese un nuevo color");
                    string? Ncolor = Console.ReadLine();
                    p1.CambiarColor(Ncolor);
                break;
                case 2:
                    p1.Atacar(p2);
                    break;
                case 3:
                    Console.WriteLine("Cuanto daño recibio?");
                    int daño = int.Parse(Console.ReadLine());
                    p1.RecibirDaño(daño);
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
            Muestra(p1);
            Muestra(p2);
        }
        while (p1.Vida > 0 && p2.Vida > 0);
        Console.WriteLine("!!");
        Console.ReadKey();
    }
}
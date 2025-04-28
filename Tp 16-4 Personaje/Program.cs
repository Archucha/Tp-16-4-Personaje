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
        p.VidaTotal = p.Vida;
        Console.WriteLine("Ingrese la defensa del personaje");
        p.Defensa = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la fuerza del personaje");
        p.Fuerza = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el mana del personaje");
        p.Mana = int.Parse(Console.ReadLine());
        p.ManaTotal = p.Mana;
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
        PocionVida pocV = new PocionVida();
        PocionMana pocM = new PocionMana();

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
            Console.WriteLine("4:Usar pocion");
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
                case 4:
                    Console.WriteLine("Ingrese que pocion desea usar");
                    Console.WriteLine("1:Vida");
                    Console.WriteLine("2:Mana");
                    int selec = int.Parse(Console.ReadLine());
                    switch(selec)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el minimo que puede curar");
                            pocV.Minimo = int.Parse(Console.ReadLine());
                            pocV.Usar(p1);
                            Console.WriteLine(pocV.Cura);
                            break;
                    }
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
using System.Drawing;
using Tp_16_4_Personaje;
using Tp_16_4_Personaje.Equipables;
using Tp_16_4_Personaje.Pociones;
internal class Program
{
    public static PocionVida CrearPocionVida()
    {
        PocionVida pocV = new();
        Console.WriteLine("Ingrese el minimo que puede curar");
        pocV.Minimo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el maximo que puede curar");
        pocV.Maximo = int.Parse(Console.ReadLine());
        return pocV;
    }

    public static PocionMana CrearPocionMana()
    {
        PocionMana pocM = new();
        Console.WriteLine("Ingrese el minimo que puede curar");
        pocM.Minimo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el maximo que puede curar");
        pocM.Maximo = int.Parse(Console.ReadLine());
        return pocM;
    }
    public static void Carga(Personaje p)
    {
        Inventario inv = new Inventario();
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
        p.Inventario.AgregarItem(CrearPocionMana());
        p.Inventario.AgregarItem(CrearPocionVida());
        Casco casco = new Casco();
        p.Inventario.AgregarItem(casco);
        Pechera pechera = new Pechera();
        p.Inventario.AgregarItem(pechera);
        Espada espada = new Espada();
        p.Inventario.AgregarItem(espada);
        p.ManaTotal = p.Mana;   
    }
    public static void Muestra(Personaje p)
    {
        Console.WriteLine("========Datos========");           
        Console.WriteLine("Color: " + p.Color);
        Console.WriteLine("Vida: " + p.Vida);
        Console.WriteLine("Mana: " + p.Mana);
        Console.WriteLine("=======Objetos=======");
        int i = 1;
        foreach (Item item in p.Inventario.items)
        {
            Console.WriteLine(i + ": " + item);
            i++;
        }
    }
    public static void Main(string[] args)
    {
        Personaje p1 = new Personaje();
        Personaje p2 = new Personaje();
        PocionVida pocV = new PocionVida();
        PocionMana pocM = new PocionMana();
        Inventario Inv = new Inventario();
       

        Console.WriteLine("Carga personaje 1");
        Carga(p1);
        Console.WriteLine("Carga personaje 2");
        Carga(p2);
        do
        {
            Muestra(p1);
            Console.WriteLine("Ingrese su accion");
            Console.WriteLine("1: Cambiar color");
            Console.WriteLine("2: Atacar");
            Console.WriteLine("3: Recibir daño");
            Console.WriteLine("4: Usar item");
            Console.WriteLine("5: Te encontraste una pocion");
            Console.WriteLine("6: Equipar item");
            Console.WriteLine("7: Desequipar item");
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
                    Console.WriteLine("Ingrese que item desea usar");
                    int i = 1;
                    foreach (Item item in p1.Inventario.items)
                    {
                        Console.WriteLine(i + ": " + item);
                        i++;
                    }
                    int selec = int.Parse(Console.ReadLine());
                    Item itemSeleccionado = p1.Inventario.items[selec - 1];
                    int restauro = 0;
                    if (itemSeleccionado is IUsar ItemUsable)
                    {
                        restauro = ItemUsable.Usar(p1);
                    }
                    Console.WriteLine(itemSeleccionado + " Restauro: " + restauro);   
                    p1.Inventario.QuitarItem(itemSeleccionado);
                    break;
                case 5:
                    Console.WriteLine("Ingrese que pocion se encontro");
                    Console.WriteLine("1:Vida");
                    Console.WriteLine("2:Mana"); 
                    int selecc = int.Parse(Console.ReadLine());
                    switch (selecc)
                    {
                        case 1:
                            p1.Inventario.AgregarItem(CrearPocionVida());
                            break;
                        case 2:
                            p1.Inventario.AgregarItem(CrearPocionMana());
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine("Ingrese que item desea equiparse");
                    int j = 1;
                    foreach (Item item in p1.Inventario.items)
                    {
                        Console.WriteLine(j + ": " + item);
                        j++;
                    }
                    int elej = int.Parse(Console.ReadLine());
                    Item ItemSeleccionado = p1.Inventario.items[elej - 1];
                    if (ItemSeleccionado is IEquipar ItemEquipable)
                    {
                        ItemEquipable.Equipar(p1);
                    }
                    break;
                case 7:
                    Console.WriteLine("Ingrese que item desea equiparse");
                    int k = 1;
                    foreach (Item item in p1.Inventario.items)
                    {
                        Console.WriteLine(k + ": " + item);
                        k++;
                    }
                    int eleji = int.Parse(Console.ReadLine());
                    Item ItemSeleccionado2 = p1.Inventario.items[eleji - 1];
                    if (ItemSeleccionado2 is IEquipar ItemEquipable2)
                    {
                        ItemEquipable2.Desequipar(p1);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    public class Inventario
    {
        public Personaje pj { get; set; } 
        public List<Item> items { get; set; } = new();
        public void AgregarItem(Item item)
        {
            items.Add(item);
            item.inventario = this;
        }
        public void QuitarItem(Item item)
        {
            items.Remove(item);
            item.inventario = null;
        }
    }
}

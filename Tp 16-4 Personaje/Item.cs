using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_16_4_Personaje
{
    public abstract class Item
    {
        public Inventario? inventario { get; set; }
        public int Restauro { get; set; }
        public string descripcion { get; set; }

    }
}

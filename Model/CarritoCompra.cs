using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CarritoCompra
    {        
        public List<Producto> Productos { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public CarritoCompra ()
        {
            Productos = new List<Producto>();
        }
    }
}

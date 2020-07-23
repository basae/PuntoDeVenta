using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Venta
    {
        public int? Id { get; set; }
        public List<Producto> Productos { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}

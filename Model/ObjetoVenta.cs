using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ObjetoVenta
    {
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }

    }
}

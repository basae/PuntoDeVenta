using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Respuesta<T>
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public T Resultado { get; set; }
        public IEnumerable<T> ListaResultado { get; set; }
    }
}

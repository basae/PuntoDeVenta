using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace CapaDatos
{
    public class ProductoDatos
    {
        public Respuesta<Producto> CrearProducto(Producto _producto)
        {
            Respuesta<Producto> Respuesta = new Respuesta<Producto>();
            try
            {

            }
            catch(Exception ex)
            {
                Respuesta.Error = true;
                Respuesta.Mensaje = ex.Message;
            }
            return Respuesta;
        }
    }
}

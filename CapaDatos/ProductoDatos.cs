using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace CapaDatos
{
    public class ProductoDatos:ConexionBD
    {
        public Respuesta<Producto> CrearProducto(Producto _producto)
        {
            Respuesta<Producto> Respuesta = new Respuesta<Producto>();
            try
            {
                Dictionary<string, object> Parametros = new Dictionary<string, object>();
                Parametros.Add("@Nombre", _producto.Nombre);
                Parametros.Add("@Precio", _producto.Precio);
                Parametros.Add("@Existencia", _producto.Existencia);

                bool RespuestaBD = EjecutarProcedimientoAlmacenado("sp_ins_Producto", Parametros);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

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

                var dt = EjecutarProcedimientoAlmacenadoDataTable("sp_ins_Producto", Parametros);
                if (dt.Rows.Count > 0)
                {                    
                    Respuesta = ConsultaProducto(Convert.ToInt32(dt.Rows[0][0]));
                }
            }
            catch(Exception ex)
            {
                Respuesta.Error = true;
                Respuesta.Mensaje = ex.Message;
            }
            return Respuesta;
        }
        public Respuesta<Producto> ConsultaProducto()
        {
            Respuesta<Producto> Respuesta = new Respuesta<Producto>();
            try
            {                
                var RespuestaBD = EjecutarProcedimientoAlmacenadoDataTable("sp_sel_Producto");
                if(RespuestaBD.Rows.Count>0)
                {
                    Respuesta.ListaResultado = from r in RespuestaBD.Rows.Cast<DataRow>()
                                               select new Producto
                                               {
                                                   Id= r.Field<int?>("Id"),
                                                   Nombre=r.Field<string>("Nombre"),
                                                   Precio=r.Field<decimal?>("Precio"),
                                                   Existencia = r.Field<decimal?>("Existencia"),
                                                   Estatus=r.Field<bool>("Estatus")
                                               };
                }
            }
            catch (Exception ex)
            {
                Respuesta.Error = true;
                Respuesta.Mensaje = ex.Message;
            }
            return Respuesta;
        }
        public Respuesta<Producto> ConsultaProducto(int Id)
        {
            Respuesta<Producto> Respuesta = new Respuesta<Producto>();
            try
            {
                Dictionary<string, object> Parametros = new Dictionary<string, object>();
                Parametros.Add("@Id", Id);
                var RespuestaBD = EjecutarProcedimientoAlmacenadoDataTable("sp_sel_Producto_por_Id", Parametros);
                if (RespuestaBD.Rows.Count > 0)
                {
                    Respuesta.Resultado = (from r in RespuestaBD.Rows.Cast<DataRow>()
                                               select new Producto
                                               {
                                                   Id = r.Field<int?>("Id"),
                                                   Nombre = r.Field<string>("Nombre"),
                                                   Precio = r.Field<decimal?>("Precio"),
                                                   Existencia = r.Field<decimal?>("Existencia"),
                                                   Estatus = r.Field<bool>("Estatus")
                                               }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Respuesta.Error = true;
                Respuesta.Mensaje = ex.Message;
            }
            return Respuesta;
        }

    }
}

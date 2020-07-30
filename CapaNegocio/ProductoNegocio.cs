using CapaDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        private ProductoDatos _repositorio;

        public ProductoNegocio()
        {
            _repositorio = new ProductoDatos();
        }
        public Respuesta<Producto> CrearProducto(Producto _producto)
        {
            Respuesta<Producto> Respuesta = new Respuesta<Producto>();
            try
            {
                if (string.IsNullOrEmpty(_producto.Nombre) || string.IsNullOrWhiteSpace(_producto.Nombre))
                    throw new Exception("El nombre del producto no puede ser nulo");
                if (_producto.Existencia <= 0)
                    throw new Exception("La existencia debe ser mayor a 0");
                if (_producto.Precio < 0)
                    throw new Exception("El precio debe ser mayor o igual a cero");
                Respuesta = _repositorio.CrearProducto(_producto);

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

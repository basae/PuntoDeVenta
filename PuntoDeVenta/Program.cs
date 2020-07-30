
using CapaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ProductoNegocio _repositorioProducto =new ProductoNegocio();
            Producto _producto = new Producto();
            Console.WriteLine("Nombre del Producto");
            _producto.Nombre = Console.ReadLine();

            Console.WriteLine("Precio del Producto");
            _producto.Precio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Existencia del Producto");
            _producto.Existencia = Convert.ToDecimal(Console.ReadLine());

            _repositorioProducto.CrearProducto(_producto);

        }
    }
}

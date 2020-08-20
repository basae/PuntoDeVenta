
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

            var respuesta=_repositorioProducto.CrearProducto(_producto);

            Console.WriteLine("{0}\t{1}\t{2:C}\t{3}\t{4}", respuesta.Resultado.Id, respuesta.Resultado.Nombre, respuesta.Resultado.Precio, respuesta.Resultado.Existencia, respuesta.Resultado.Estatus);

            //var Resultado = _repositorioProducto.ConsultaProducto();
            //if (Resultado.Error)
            //    Console.WriteLine("Error:{0}", Resultado.Mensaje);
            //else
            //{
            //    Console.WriteLine("ID\tNOMBRE\tPRECIO\tEXISTENCIA\tESTATUS");
            //    foreach (var producto in Resultado.ListaResultado)
            //    {
            //        Console.WriteLine("{0}\t{1}\t{2:C}\t{3}\t{4}", producto.Id, producto.Nombre, producto.Precio, producto.Existencia, producto.Estatus);
            //    }
            //}
            Console.ReadKey();

        }
    }
}

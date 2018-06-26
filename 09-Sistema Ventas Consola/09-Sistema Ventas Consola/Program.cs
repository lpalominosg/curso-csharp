using System;

namespace _09_Sistema_Ventas_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Carrito carrito = new Carrito();
            carrito.cargarproductos();
            carrito.mostrarproductos();

            Console.ReadLine();
            
        }
    }
}

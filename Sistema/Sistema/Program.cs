using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Modelo;
using Sistema.Controlador.Tools;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venta> pedido = new List<Venta>();

            Producto producto = new Producto("001", "Vino", 3500);
            Venta venta = new Venta(producto, 3);
            pedido.Add(venta);
            pedido.Add(new Venta(new Producto("002", "Lomo", 20000), 1));
            pedido.Add(new Venta(new Producto("003", "Carbon", 2000), 50));

            Console.WriteLine("El total del pedido es : " + VentaControlador.Total(pedido));
            Console.WriteLine("Usted se lleva : "
                + VentaControlador.Cantidad(pedido) + " productos");
            Console.WriteLine("la venta máxima es  : " + VentaControlador.VentaMaxima(pedido));
            Console.WriteLine("Mas vendido : " + VentaControlador.MasVendido(pedido));
            Console.Read();
        }
    }
}

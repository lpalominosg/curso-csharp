using System;
using System.Collections.Generic;


namespace _09_Sistema_Ventas_Consola
{
    class Carrito
    {

        public Carrito()
        {

        }

        public List<Inventario> bodega{get; set;}
        public void cargarproductos()
        {
            bodega = new List<Inventario>();
            
            Producto producto1 = new Producto(1, "Cel IPhone", 150000);
            Inventario inventario1 = new Inventario(producto1, 50);
            bodega.Add(inventario1);

            Producto producto2 = new Producto(2, "Tablet Galaxy", 250000);
            Inventario inventario2 = new Inventario(producto2, 10);
            bodega.Add(inventario2);

            Producto producto3 = new Producto(3, "Proyector", 300000);
            Inventario inventario3 = new Inventario(producto3, 5);
            bodega.Add(inventario3);
            
        }
        public void mostrarproductos()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Catalogo de Productos");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Código \t  Producto  \t Precio \t Stock");
            Console.WriteLine("------ \t  --------  \t ------ \t -----");
            foreach (var inventario in bodega)
            {
                Console.WriteLine(inventario.producto.cod_producto + " \t " + inventario.producto.producto + " \t " + inventario.producto.valor + " \t " + inventario.cantidad);
            }
            Console.WriteLine("\n");
        }

        public void mostrarmenu() { 
        

        }

    }
}

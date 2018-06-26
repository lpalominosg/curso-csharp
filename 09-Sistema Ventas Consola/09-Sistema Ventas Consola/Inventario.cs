using System;
using System.Collections.Generic;


namespace _09_Sistema_Ventas_Consola
{
    class Inventario
    {
        public Inventario() { 
        }
        public Inventario(Producto _producto, int _cantidad)
        {
            producto = _producto;
            cantidad = _cantidad;
        }

        public Producto producto { get; set; }
        public int cantidad { get; set; }

    }
}

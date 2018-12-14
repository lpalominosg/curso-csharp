using System.Collections.Generic;
using System.Linq;

using Sistema.Modelo;

namespace Sistema.Controlador.Tools
{
    public abstract class VentaControlador
    {
        public static int Total(List<Venta> pedido)
        {
            int total = 0;
            foreach (Venta venta in pedido)
            {

                total = total + venta.Producto.Valorunitario
                    * venta.Cantidad;

            }
            return total;
        }

        public static int Cantidad(List<Venta> pedido)
        {
            int total = 0;
            foreach (Venta venta in pedido)
            {
                total = total + venta.Cantidad;

            }
            return total;
        }

        public static int VentaMaxima(List<Venta> pedido)
        {

            int total = 0;
            foreach (Venta venta in pedido)
            {
                if ((venta.Producto.Valorunitario * venta.Cantidad) > total)
                {
                    total = (venta.Producto.Valorunitario * venta.Cantidad);
                }
            }
            return total;
        }

        public static string MasVendido(List<Venta> pedido)
        {

            int total = 0;
            string prod = "";
            foreach (Venta venta in pedido)
            {

                if (venta.Cantidad > total)
                {
                    total = venta.Cantidad;
                    prod = venta.Producto.Nombre;
                }
            }
            return prod;
        }

        public static int CantidadBaseProducto(List<Producto> baseProducto) {
 
            return baseProducto.Count();
        }

        public static int SumaPUBaseProducto(List<Producto> baseProducto) {

            int suma = 0;
            foreach (Producto producto in baseProducto) {
                suma = suma + producto.Valorunitario;

            }
            return suma;
        }
    }
}

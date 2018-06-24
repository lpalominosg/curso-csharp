using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Control_de_Flujo_y_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estructura de control IF ELSE");
            int edad;
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18) {
                Console.WriteLine("Eres nayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
            Console.ReadLine();
            Console.WriteLine("Estructura de control SWITCH CASE");

            int descuento;
            Console.WriteLine("Ingresa descuento a aplicar: ");
            descuento = Convert.ToInt32(Console.ReadLine());

            string resul;

            switch (descuento)
            {
                case 1:
                    resul = "Descuento aplicado es 50 %";
                    break;
                case 2:
                    resul = "Descuento aplicado es 30 %";
                    break;
                default:
                    resul = "Descuento no permitido";
                    break;
            }
            Console.WriteLine("Su descuento es: {0}", resul);
            Console.ReadLine();

        }
    }
}

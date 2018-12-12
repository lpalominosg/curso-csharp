using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public abstract class Calculo
    {
        public static int Suma(int valor1, int valor2) {
            return valor1 + valor2;
        }

        public static string Saludo(string nombre) {
            return "Hola " + nombre + " cómo estás?";
        }

        public static int CalculoAreaRectango(int ancho, int largo) {
            return ancho * largo;
        }

        public static void tabla(int numero, int limite) {
            for (int i=1; i<=limite; i++) {
                Console.WriteLine("{0} * {1} = {2} ",numero,i,(i * numero ));
            }

        }

    }
}

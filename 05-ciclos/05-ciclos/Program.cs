using System;
using System.Threading;

namespace _05_ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("-------------------------------");
            Console.WriteLine("CICLO FOR INFINITO");
            Console.WriteLine("-------------------------------");
            int numero=0;
            for (; ; )
            {
                Console.WriteLine("Estoy atrapado en un ciclo infinito, la cuenta es: " + numero++);
                Thread.Sleep(100);
            }
            
            Console.Clear();
            */

            Console.WriteLine("-------------------------------");
            Console.WriteLine("CICLO CONDICIONAL WHILE ");
            Console.WriteLine("-------------------------------");
            int  limite = 0;
            while (limite < 20)
            {
                Console.WriteLine("Valor actual es: {0}", limite);
                limite++;
                Thread.Sleep(100);
            }
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("CICLO FOR ");
            Console.WriteLine("-------------------------------");
            
            limite = 0;

            for(int i=0 ; i<20 ; i++)
            {
                Console.WriteLine("Valor actual es: {0}", limite);
                limite++;
                Thread.Sleep(100);
            }
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("CICLO CONDICIONAL DO WHILE ");
            Console.WriteLine("-------------------------------");
            
            limite = 0;
            do
            {
                Console.WriteLine("Valor actual es: {0}", limite);
                limite++;
                Thread.Sleep(100);
            } while (limite < 20);
            Console.ReadLine();

            /*
            IMPORTANTE
            ------------------------------------------------------------
            Se pueden anidar ciclos, pero no es muy recomendable ya que
            implica un costo exponencial del procesamiento del algoritmo
            */


        }
    }
}

using System;
using Empresa.Models;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador trabajador = new Gerente();
            trabajador.Nombre = "Alvaro";
            trabajador.Tipo = "Ejecutivo";
            int sueldo = trabajador.Liquidación(1000000);
            Console.WriteLine("Sueldo de trabajador : " + sueldo);


            Trabajador trabajador1 = new Colaborador("Pamela Gonzalez", "Operador");
            sueldo = trabajador1.Liquidación(1000000);
            Console.WriteLine("Sueldo de trabajador1 : " + sueldo);
            Console.Read();
        }
    }
}

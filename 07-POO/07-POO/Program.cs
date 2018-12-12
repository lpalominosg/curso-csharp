using System;
using Emoresa.Models;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hola curso...");
            //Console.Read();

            // Tipos de datos primitivos

            // tipo caracter
            //string texto;
            //texto = "Curso C-sharp"; //asignar variable
            //Console.WriteLine(texto);
            //Console.Read();

            //string nombre = "Alvaro";
            //string apellido = "fuentes";

            //string nombre_completo = nombre + " " +  apellido;
            //Console.WriteLine(nombre_completo);
            //Console.WriteLine(nombre + " " + apellido);
            //Console.WriteLine("{0} {1}", nombre, apellido);
            //Console.Read();

            //tipo entero
            //int valor;

            //valor = 10;

            //Console.Write("El número es : ");
            //Console.WriteLine(valor);
            //Console.Read();

            //int a, b;
            //a = 10;
            //b = 5;

            //int suma = a + b;
            //Console.WriteLine("La suma de a = {0} y b = {1} es : {2}",a,b,suma);
            ////Console.Read();

            //int mult = a * b;
            //Console.WriteLine("La mult. de a = {0} y b = {1} es : {2}", a, b, mult);
            //Console.Read();

            //long a = 1000;
            //long resp = a * 10000;
            //Console.WriteLine("El valor es : " + resp);
            //Console.Read();

            //Valor decimales
            //double valor = 3.64435;
            //Console.WriteLine("El valor decimal es : " + valor);
            //Console.Read();

            // arrays
            /*
            string[] apellidos = new string[5];
            apellidos[0] = "Pérez";
            apellidos[1] = "Tapia";
            apellidos[2] = "Pino";
            apellidos[3] = "Gonzalez";
            apellidos[4] = "Caro";

            Console.WriteLine("El apellido lugar 3 es : " + apellidos[2]);
            Console.Read();
            */


            //int[] numeros = new int[3];
            //numeros[2] = 10;
            //Console.WriteLine(numeros[0]);
            //Console.Read();

            //int[] datos = new int[5];

            //datos[0] = 10;
            //datos[1] = 5;
            //datos[2] = 15;
            //datos[3] = 25;
            //datos[4] = 30;

            // Cambiar los datos del vector ordenando de mayor a menor

            //int[] datos2 = new int[5];
            //datos2[0] = 30;
            //datos2[1] = 25;
            //datos2[2] = 15;
            //datos2[3] = 10;
            //datos2[4] = 5;

            // Estucturas condicionales - Control de Flujo

            //bool estado = false;
            //estado = true;



            //if ( true ) {
            //    Console.WriteLine("Se cumple");
            //}

            //int a, b;
            //a = 10;
            //b = 5;

            //if (a == b)
            //{
            //    Console.WriteLine("a es igual a b");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("a es menor que b");
            //}
            //else {
            //    Console.WriteLine("a es mayor que b");
            //}

            //int edad = 25;

            // construya un algoritmo que muestre 
            // si es mayor de edad o es menor de edad

            //if (edad >= 18)
            //{
            //    Console.WriteLine("Es mayor de edad");
            //}
            //else {
            //    Console.WriteLine("Es menor de edad");
            //}

            //int tipo_descuento = 2;
            //switch(tipo_descuento) {
            //    case 1:
            //        Console.WriteLine("Desc 20%");
            //        break;
            //    case 2:
            //        Console.WriteLine("Desc 10%");
            //        break;
            //    case 3:
            //        Console.WriteLine("Desc 5%");
            //        break;
            //}

            // ciclos loops

            //for (int i=0; i<10;i++) {
            //    Console.WriteLine("El numero es : " + (i+1));
            //}

            //int tope = 50;
            //int i = 0;
            //while (i <= tope) {
            //    Console.WriteLine("El numero es : " + i);
            //    i++;
            //}

            //int tope = 50;
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("El numero es : " + i);
            //    i++;
            //} while (i <= tope);


            //generar la la tabla de un numero con un for

            //int tabla = 1;
            //int i;
            //for (i = 1 ;i<=10;i++) {
            //    Console.WriteLine(" {0} * {1} = {2} ",tabla,i, (tabla * i));
            //}

            //i = 1;

            //while (i < 11) {
            //    Console.WriteLine(" {0} * {1} = {2} ", tabla, i, (tabla * i));
            //    i++;
            //}

            //i = 1;

            //do {
            //    Console.WriteLine(" {0} * {1} = {2} ", tabla, i, (tabla * i));
            //    i++;
            //} while (i < 11);

            //Saludo();
            //Saludo2("Alvaro");
            //Saludo3("Alvaro","Fuentes");

            //string saludo = Saludo4("Alvaro Fuentes");
            //Console.WriteLine(saludo);

            //int respuesta = Suma(10, 30);
            //Console.WriteLine("Suma es : " + Suma(10, 30));

            //Console.WriteLine("Ingrese el número : ");

            //string entrada = Console.ReadLine();

            //Creartabla(int.Parse(entrada));

            //Listar(5, 10);

            // Crear un objeto o instacia

            //Producto producto = new Producto();
            //producto.Codigo = "CC";
            //producto.Nombre = "Cuenta Corriente";
            //producto.Tipo = "Bancario";

            //Vehiculo auto = new Vehiculo();
            //auto.Matricula = "AABB01";
            //auto.Modelo = "Corolla";
            //auto.Marca = "Toyota";
            //auto.Ruedas = 5;


            ////Console.WriteLine(producto.Nombre);
            //Console.WriteLine(auto.Marca + " " + auto.Ruedas);

            //Cliente cliente = new Cliente();
            //cliente.Rut = "123456789";
            //cliente.Nombre = "Maria";
            //cliente.Apellido = "Gonzalez";
            //cliente.Tipo = 0;

            //Cliente cliente2 = new Cliente("2222222","Juan","Perez",1);

            //Cliente cliente3 = new Cliente("12345","Fuentes");

            //Hijo hijo = new Hijo();
            //hijo.Apellido = "Fuentes";
            //hijo.Herencia = 100;
            //hijo.Nombre = "Carlos";
            //hijo.Mama = "Andrea";

            //Console.WriteLine(hijo.Apellido);

            //Auto auto = new Auto();
            //auto.Matricula = "AABB01";
            //auto.Marca = "Toyota";
            //auto.Color = "Amarillo";
            //auto.Tipo = "Familiar";

            //string texto = Calculo.Saludo("Alvaro");
            //Console.WriteLine(texto);

            //int resp = Calculo.Suma(100, 250);
            //Console.WriteLine("La suma es : " + resp);

            //Calculo.tabla(5, 10);

            Venta venta = new Venta();
            int totalneto = venta.Totalizar(100, 30);
            Console.WriteLine("Sub total : " + totalneto);
            double totalmasiva = venta.Agregariva(totalneto);
            Console.WriteLine("Total con iva : " + totalmasiva);




            Console.Read();
        }

        public static void Saludo()
        {
            Console.WriteLine("Mi método");
        }

        public static void Saludo2(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        public static void Saludo3(string nombre, string apellido)
        {
            Console.WriteLine("Hola " + nombre + " " + apellido);
        }

        public static string Saludo4(string nombre)
        {
            return "Hola " + nombre;
        }

        // Crear metodo que devuleva la suma de dos numeros enteros

        public static int Suma(int a, int b)
        {
            //int suma = a + b;
            return a + b;
        }

        // crear un metodo que imprima la tabla de un numero
        // Creartabla

        public static void Creartabla(int numero)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(" {0} * {1} = {2} ", numero, i, (numero * i));
            }

        }

        // generar una lista de numeros enteros desde un inicio y fin
        // imprimir en consola

        public static void Listar(int inicio, int fin)
        {

            //for (int i = inicio; i<=fin;i++) {
            //    Console.WriteLine("N° lista : " + i );
            //}

            do
            {
                Console.WriteLine("N° lista : " + inicio);
                inicio++;
            } while (inicio <= fin);



        }



    }
}


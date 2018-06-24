using System;

namespace _03_Variables
{

    struct Libros
    {
        public string titulo;
        public string autor;
        public string tema;
        public int libro_id;
    };  

    class Program
    {

        enum misemana
        {
            lunes = 1,
            martes = 2,
            miercoles = 3,
            jueves = 4,
            viernes = 4,
            sabado = 6,
            domingo = 7
        }


        static void Main(string[] args)
        {
            
            // Variables locales
            string nombre;
            int edad;

            nombre = "Juan";
            edad = 25;

            // Utilizando secuencias de escape de cadenas
            Console.WriteLine("Mi nombre es {0} y mi edad es {1}.",nombre,edad);
            Console.ReadLine();

            /* SECUENCIAS DE ESCAPE EN C# */
            /* 

            \a	Campana (alerta)
            \b	Retroceso
            \f	Avance de página
            \n	Nueva línea
            \r	Retorno de carro
            \t	Tabulación horizontal
            \v	Tabulación vertical
            \'	Comilla simple
            \"	Comillas dobles
            \\	Barra diagonal inversa
            \?	Signo de interrogación literal
            \ ooo	Carácter ASCII en notación octal
            \x hh	Carácter ASCII en notación hexadecimal
            \x hhhh	Carácter Unicode en notación hexadecimal si esta secuencia
                    de escape se utiliza en una constante de caracteres anchos o un literal de cadena Unicode.

            */

            Console.WriteLine("Hola \t alumnos \n\nQue tal!!!");
            Console.ReadLine();

            /* TIPOS DE VALOR */

                /* TIPOS SIMPLES */

                    /* Enteros con signo */
                    sbyte mvar1 = 1; // 8 bits, de -128 a 127
                    short mvar2 = 2; // 16 bits, de -32,768 a 32,767
                    int mvar3 = 100; // 32 bits, de -2,147,483,648 a 2,147,483,647
                    long mvar4 = 123456; // 64 bits, de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807

                    /* Enteros sin signo */
                    byte mvar5 = 1; // 8 bits, de 0 a 255
                    ushort mvar6 = 2; // 16 bits, de 0 a 65,535
                    uint mvar7 = 100; // 32 bits, de 0 a 4,294,967,295
                    ulong mvar8 = 1000; // 64 bits, de 0 a 18,446,744,073,709,551,615

                    /* Caracteres unicode */
                    char[] chars = new char[6];
                    chars[0] = 'a';
                    chars[1] = 'l';
                    chars[2] = 'v';
                    chars[3] = 'a';
                    chars[4] = 'r';
                    chars[5] = 'o';
                    string charsStr = new string(chars);
                    Console.WriteLine("Chars to string: {0}", charsStr);
                    Console.ReadLine();

                    /* Punto flotante */
                    /*
                    float 7 dígitos
                    double entre 15-16 dígitos
                    decimal entre 28-29 dígitos.
                    */

                    float mvar9 = 0.1234f; // 32 bits, de 1.5 × 10 exp −45 a 3.4 × 10 exp 38, precisión de 7 dígitos
                    double mvar10 = 1.234; // 64 bits, de 5.0 × 10 exp −324 a 1.7 × 10 exp 308, precisión de 15 dígitos

                    /* Decimal de alta precisiòn */
                    decimal mvar11 = 300.5m; // 128 bits, al menos de –7.9 × 10 exp −28 a 7.9 × 10 exp 28, con una precisión mínima de 28 dígitos

                    /* Booleano*/
                    bool mvar12 = true;
                    bool mvar13 = false;

                /* TIPOS ENUMERACION */
                /*
                enum misemana
                {
                    lunes,
                    martes,
                    miercoles,
                    jueves,
                    viernes,
                    sabado,
                    domingo
                }
                */

                Console.WriteLine(misemana.lunes);
                Console.WriteLine((int)misemana.lunes);
                Console.ReadLine();

            /* TIPOS ESTRUCTURA */
            /*
            struct Libros
            {
                public string titulo;
                public string autor;
                public string tema;
                public int libro_id;
            };
            */
                Libros libro1;
                libro1.titulo = "Aprender a Programar";
                libro1.autor = "Alvaro Fuentes";
                libro1.tema = "Lenguaje de programaciòn en C#";
                libro1.libro_id = 201807;

                Console.WriteLine("Mi primer libro es: ");
                Console.WriteLine("Código {0}, el título es {1}, el autor es {2} y el tema es {3}.", libro1.libro_id, libro1.titulo, libro1.autor, libro1.tema);
                Console.ReadLine();


        /* TIPOS DE REFERENCIA */

            /* TIPOS CLASE */
                /* TIPOS OBJECT */

                    int i = 123;
                    object o = i;    // Boxing
                    int j = (int)o;  // Unboxing

                /* TIPOS CADENA STRING -  Lo veremos en el siguiente modulo */

                /* TIPOS CLASE DEFINIDAS POR EL USUARIO -  Lo veremos en el siguiente modulo  */

                /* TIPOS INTERFACE DEFINIDAS POR EL USUARIO -  Lo veremos en el siguiente modulo  */
        
        
        /* CONSTANTES */

        const double pi = 3.14159;

        double r;
        Console.WriteLine("Ingresa el radio: ");
        r = Convert.ToDouble(Console.ReadLine());

        double areaCirculo = pi * r * r;
        Console.WriteLine("Radio: {0}, Area: {1}", r, areaCirculo);
        Console.ReadLine();
        
        }
    }
}

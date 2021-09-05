using System;

namespace ejercicio_seccion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre:");

            string name = Console.ReadLine();

            Console.WriteLine("Hola " + name);

            Console.ReadKey();


            Console.WriteLine("Introduce una ciudad:");

            string city = Console.ReadLine();

            Console.WriteLine("Hola " + name + " bienvenido a " + city);

            Console.ReadKey();


        }
    }
}

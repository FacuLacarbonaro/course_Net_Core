using System;

namespace Section3_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca el valor del producto");

            var valor = int.Parse(Console.ReadLine());
            Console.WriteLine("efectivo o tarjeta");
            var tipo = Console.ReadLine();

            if (tipo == "tarjeta")
            {
                Console.WriteLine("Introduzca el numero de tarjeta");
                var tarjeta = Console.ReadLine();

                Console.WriteLine($"Su tarjeta es {tarjeta}");
                Console.ReadKey();
            }

        }
    }
}

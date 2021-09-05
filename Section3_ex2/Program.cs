using System;

namespace Section3_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            var numero1 = Console.ReadLine();
            Console.WriteLine("Introduzca otro numero");
            var numero2 = Console.ReadLine();

            if (int.Parse(numero1) > int.Parse(numero2))
            {
                Console.WriteLine(numero1 + " es mayor que " + numero2);
            }
            else
            {
                Console.WriteLine(numero2 + " es mayor que " + numero1);
            }
        }
    }
}

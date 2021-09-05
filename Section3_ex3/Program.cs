using System;

namespace Section3_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el dia de la semana (Lunes, Martes, Miercoles, Jueves, Viernes, Sabado o Domingo");
            string dia = Console.ReadLine();

            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("no es fin de semana");
                Console.ReadKey();
            }
            else
            {
                if (dia == "sabado" || dia == "domingo")
                {
                    Console.WriteLine("Es fin de semana");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No existe el dia introducido");
                    Console.ReadKey();
                }
            }

        }
    }
}

using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 2: Scrieti un program care va afisa factorialul unui numar n, 
            n fiind citit de la tastatura
             */

            Console.WriteLine("Introduceri numarul: ");
            int m = int.Parse(Console.ReadLine());
            var factorial = 1;
            if (m > 0)
            {
                for (var i = 1; i <= m; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine($"Factorialul numarului {m} este: {factorial}");
            }
        }
    }
}

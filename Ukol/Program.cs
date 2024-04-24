using System;

namespace Ukol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.

            Console.WriteLine("Zadej první číslo:");
            double prvniCislo =double.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhé číslo:");
            double druheCislo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Součet čísel je {prvniCislo + druheCislo}");
        }
    }
}

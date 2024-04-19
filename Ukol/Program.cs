using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první číslo:");
            double prvniCislo =double.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhé číslo:");
            double druheCislo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Součet čísel je {prvniCislo + druheCislo}");
        }
    }
}

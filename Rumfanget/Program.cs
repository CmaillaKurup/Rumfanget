using System;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv Højden her:");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv længden her");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv bredten her");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Rumfanget er " + (h * l * b));
        }
    }
}

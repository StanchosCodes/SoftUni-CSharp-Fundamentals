using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = meters / 1000.0m;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}

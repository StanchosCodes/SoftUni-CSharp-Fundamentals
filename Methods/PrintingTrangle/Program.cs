using System;

namespace PrintingTrangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i < height; i++)
            {
                PrintingLine(1, i);
                Console.WriteLine();
            }
            for (int i = height; i >= 1; i--)
            {
                PrintingLine(1, i);
                Console.WriteLine();
            }
        }
        static void PrintingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

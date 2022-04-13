using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            n *= 2;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                if (i == n)
                {
                    Console.WriteLine($"Sum: {sum}");
                }
            }
        }
    }
}

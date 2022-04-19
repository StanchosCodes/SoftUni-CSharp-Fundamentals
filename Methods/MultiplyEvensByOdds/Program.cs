using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            var sumOfEvenDigits = GetSumOfEvenDigits(number);
            var sumOfOddDigits = GetSumOfOddDigits(number);
            Console.WriteLine(sumOfEvenDigits * sumOfOddDigits);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
             if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}

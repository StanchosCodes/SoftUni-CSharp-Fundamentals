using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool isDivisibleNumber = IsDivisibleBy8(i);
                bool isContainingOdd = IsContainingOddDigit(i);

                if (isDivisibleNumber && isContainingOdd)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsDivisibleBy8(int number)
        {
            int sumOfTheDigits = 0;

            while (number != 0)
            {
                sumOfTheDigits += number % 10;
                number /= 10;
            }

            if (sumOfTheDigits % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsContainingOddDigit(int number)
        {
            int countOfTheOddDigits = 0;
            int currentDigit = 0;

            while (number != 0)
            {
                currentDigit = number % 10;

                if (currentDigit % 2 != 0)
                {
                    countOfTheOddDigits++;
                    break;
                }
                else
                {
                    number /= 10;
                }
            }

            if (countOfTheOddDigits >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

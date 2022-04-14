using System;

namespace SpecialNumbersAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int sum = 0;
                while (currentNum != 0)
                {
                    int currentDigit = currentNum % 10;
                    currentNum /= 10;
                    sum += currentDigit;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}

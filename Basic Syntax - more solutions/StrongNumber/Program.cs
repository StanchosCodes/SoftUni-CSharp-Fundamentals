using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int fact = 0;
            int sumOfDigits = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int digit = num[i];
                digit -= 48;
                fact = digit;
                for (int j = 1; j < digit; j++)
                {
                    fact *= j;
                }
                    if (digit == 0)
                    {
                        fact++;
                    }
                sumOfDigits += fact;
                fact = 0;
            }

            int number = int.Parse(num);

            if (sumOfDigits == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

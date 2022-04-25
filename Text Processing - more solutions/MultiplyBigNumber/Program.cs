using System;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum == 0)
            {
                Console.WriteLine("0");
                return;
            }

            List<string> product = new List<string>();

            int parsingTheNum = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                parsingTheNum = (int.Parse(Convert.ToString(firstNum[i])) * secondNum) + parsingTheNum;
                product.Insert(0, (parsingTheNum % 10).ToString());
                parsingTheNum /= 10;
            }

            if (parsingTheNum > 0)
            {
                Console.WriteLine($"{parsingTheNum}{string.Join("", product)}");
            }
            else
            {
                Console.WriteLine(string.Join("", product));
            }
        }
    }
}

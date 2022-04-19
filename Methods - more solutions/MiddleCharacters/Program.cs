using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(MiddleSymbol(input));
        }

        static string MiddleSymbol(string input)
        {
            char symbol = ' ';
            string middleSymbols = "";

            if (input.Length % 2 != 0)
            {
                for (int i = 0; i <= input.Length / 2; i++)
                {
                    if (i == input.Length / 2)
                    {
                        symbol = (char)input[i];
                    }
                }
                return symbol.ToString();
            }
            else
            {
                symbol = (char)input[input.Length / 2 - 1];
                middleSymbols = symbol.ToString();
                middleSymbols += input[input.Length / 2];

                return middleSymbols;
            }
        }
    }
}

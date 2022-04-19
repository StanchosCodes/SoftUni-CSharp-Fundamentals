using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (input != "END")
            {
                string reversedInput = ReverseTheInput(input);
                Console.WriteLine(IsInputPalindrome(input, reversedInput));
                input = Console.ReadLine();
            }
        }

        static string ReverseTheInput(string input)
        {
            string reversingInput= "";
            bool isReversed = false;

            while (input != "END")
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversingInput += input[i];

                    if (i == 0)
                    {
                        isReversed = true;
                        break;
                    }
                }
                if (isReversed)
                {
                    break;
                }
            }

            return reversingInput;
        }

        static bool IsInputPalindrome(string input, string reversedInput)
        {
            if (input == reversedInput)
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

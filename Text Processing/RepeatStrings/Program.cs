using System;
using System.Linq;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string concatenatedString = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    concatenatedString += currentWord;
                }
            }

            Console.WriteLine(concatenatedString);
        }
    }
}

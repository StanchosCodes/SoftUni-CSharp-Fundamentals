using System;
using System.Linq;
using System.Text;

namespace RepeatStringsWithStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder concatenatedString = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    concatenatedString.Append(word);
                }
            }

            Console.WriteLine(concatenatedString);
        }
    }
}

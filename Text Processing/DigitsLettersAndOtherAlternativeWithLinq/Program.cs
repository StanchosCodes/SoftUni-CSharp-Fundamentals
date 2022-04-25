using System;
using System.Linq;

namespace DigitsLettersAndOtherAlternativeWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] allDigits = text
                .Where(item => char.IsDigit(item))
                .ToArray();

            char[] allLetters = text
                .Where((item) => char.IsLetter(item))
                .ToArray();

            char[] otherChars = text
                .Where((item) => !char.IsLetterOrDigit(item))
                .ToArray();

           // Console.WriteLine(string.Join("", allDigits));
            Console.WriteLine(allDigits);
            Console.WriteLine(allLetters);
            Console.WriteLine(otherChars);
        }
    }
}

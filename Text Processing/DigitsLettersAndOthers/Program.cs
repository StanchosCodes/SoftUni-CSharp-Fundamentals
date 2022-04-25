using System;
using System.Text;

namespace DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherChars = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsLetterOrDigit(character))
                {
                    if (char.IsDigit(character))
                    {
                        digits.Append(character);
                    }
                    else
                    {
                        letters.Append(character);
                    }
                }
                else
                {
                    otherChars.Append(character);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}

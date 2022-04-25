using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string cipher = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                cipher += (char)(text[i] + 3);
            }

            Console.WriteLine(cipher);
        }
    }
}

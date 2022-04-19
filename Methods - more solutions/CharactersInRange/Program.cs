using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());

            GetCharacters(character1, character2);
        }

        static void GetCharacters(char char1, char char2)
        {
            if (char1 < char2)
            {
                for (int i = char1 + 1; i < char2; i++)
                {
                   char ch = (char) i;
                    Console.Write($"{ch} ");
                }
            }
            else
            {
                for (int i = char2 + 1; i < char1; i++)
                {
                    char ch = (char)i;
                    Console.Write($"{ch} ");
                }
            }
        }
    }
}

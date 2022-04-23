using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<char, int> occurrancies = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    char currentLetter = currentWord[j];

                    if (occurrancies.ContainsKey(currentLetter))
                    {
                        occurrancies[currentLetter] += 1;
                    }
                    else
                    {
                        occurrancies.Add(currentLetter, 1);
                    }
                }
            }

            foreach (var letter in occurrancies)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}

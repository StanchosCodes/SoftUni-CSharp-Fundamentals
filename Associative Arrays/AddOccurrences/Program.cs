using System;
using System.Collections.Generic;

namespace AddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countOfWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (countOfWords.ContainsKey(wordInLowerCase))
                {
                    countOfWords[wordInLowerCase] += 1;
                }
                else
                {
                    countOfWords.Add(wordInLowerCase, 1);
                }
            }

            foreach (var word in countOfWords)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}

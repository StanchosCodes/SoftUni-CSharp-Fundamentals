using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymList = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonymList.ContainsKey(word))
                {
                    synonymList[word].Add(synonym);
                }
                else
                {
                    List<string> synonyms = new List<string> { synonym };
                    synonymList.Add(word, synonyms);
                }
            }

            foreach (var word in synonymList)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}

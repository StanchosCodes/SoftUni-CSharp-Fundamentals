using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)(?<firstWord>[A-Za-z]{3,})(\1)(\1)(?<secondWord>[A-Za-z]{3,})(\1)";

            string input = Console.ReadLine();

            MatchCollection pairMatches = Regex.Matches(input, pattern);

            List<string[]> mirrorWords = new List<string[]>();

            foreach (Match pair in pairMatches)
            {
                string firtsWord = pair.Groups["firstWord"].Value;
                string secondWordReversed = string.Join("", pair.Groups["secondWord"].Value.Reverse());


                if (firtsWord == secondWordReversed)
                {
                    mirrorWords.Add(new string[2] { pair.Groups["firstWord"].Value, pair.Groups["secondWord"].Value });
                }
            }

            if (pairMatches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairMatches.Count} word pairs found!");
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords.Select(x => $"{x[0]} <=> {x[1]}")));
            }
        }
    }
}

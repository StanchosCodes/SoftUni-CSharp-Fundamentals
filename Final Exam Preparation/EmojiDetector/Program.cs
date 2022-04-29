using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(:|\*){2}(?<emoji>[A-Z][a-z]{2,})\1{2}";
            string digitsPattern = @"\d";

            string input = Console.ReadLine();

            MatchCollection digitsMatches = Regex.Matches(input, digitsPattern);

            int coolThreshold = 1;

            foreach (Match digit in digitsMatches)
            {
                coolThreshold *= int.Parse(digit.ToString());
            }

            MatchCollection emojiMatches = Regex.Matches(input, emojiPattern);

            Dictionary<string, int> emojiInfo = new Dictionary<string, int>();

            foreach (Match emoji in emojiMatches)
            {
                int emojiCoolnes = 0;

                foreach (char ch in emoji.Groups["emoji"].Value)
                {
                    emojiCoolnes += ch;
                }

                emojiInfo.Add(emoji.ToString(), emojiCoolnes);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiInfo.Count} emojis found in the text. The cool ones are:");

            foreach (var emoji in emojiInfo)
            {
                if (emoji.Value > coolThreshold)
                {
                    Console.WriteLine(emoji.Key);
                }
            }
        }
    }
}

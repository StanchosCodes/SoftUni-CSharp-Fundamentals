using System;
using System.Text.RegularExpressions;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)+(?<color>[a-z]{3,})(@|#)+([^A-Za-z0-9])*\/+(?<amount>\d+)\/+";

            string text = Console.ReadLine();

            MatchCollection eggMatches = Regex.Matches(text, pattern);

            foreach (Match egg in eggMatches)
            {
                Console.WriteLine($"You found {egg.Groups["amount"].Value} {egg.Groups["color"].Value} eggs!");
            }
        }
    }
}

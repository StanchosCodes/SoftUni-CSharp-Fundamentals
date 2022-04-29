using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(?<food>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            string inputLine = Console.ReadLine();

            MatchCollection foodMatches = Regex.Matches(inputLine, pattern);

            int totalCalories = 0;

            foreach (Match match in foodMatches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }

            int lastingDays = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {lastingDays} days!");

            foreach (Match item in foodMatches)
            {
                Console.WriteLine($"Item: {item.Groups["food"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }
        }
    }
}

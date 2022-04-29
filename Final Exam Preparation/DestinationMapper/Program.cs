using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string mapLocations = Console.ReadLine();
            string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection destinations = Regex.Matches(mapLocations, pattern);

            int travelPoints = 0;
            List<string> places = new List<string>();

            foreach (Match match in destinations)
            {
                string destination = match.Groups["destination"].Value;
                places.Add(destination);

                travelPoints += destination.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}

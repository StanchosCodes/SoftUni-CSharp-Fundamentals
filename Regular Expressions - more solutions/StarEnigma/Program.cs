using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?!(?<attackType>[A-Z]{1})![^@\-!:>]*?-\>(?<soldiers>\d+)";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string currMessage = string.Empty;
                int countOfTheKeyLetters = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    string inputToLower = input.ToLower();

                    if (inputToLower[j] == 's' || inputToLower[j] == 't' || inputToLower[j] == 'a' || inputToLower[j] == 'r')
                    {
                        countOfTheKeyLetters++;
                    }
                }

                foreach (char ch in input)
                {
                    currMessage += (char)(ch - countOfTheKeyLetters);
                }

                Match currPlanet = Regex.Match(currMessage, pattern);

                if (currPlanet.Success)
                {
                    string currPlanetName = currPlanet.Groups["planetName"].Value;
                    char currPlanetAttackType = char.Parse(currPlanet.Groups["attackType"].Value);

                    if (currPlanetAttackType == 'A')
                    {
                        attackedPlanets.Add(currPlanetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(currPlanetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}

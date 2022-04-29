using System;
using System.Collections.Generic;

namespace Pirates
{

    class City
    {
        public City (string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string command;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] currCity = command.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string nameOfTheCity = currCity[0];
                int populationOfTheCity = int.Parse(currCity[1]);
                int goldOfTheCity = int.Parse(currCity[2]);

                if (!cities.ContainsKey(nameOfTheCity))
                {
                    cities.Add(nameOfTheCity, new City(nameOfTheCity, populationOfTheCity, goldOfTheCity));
                }
                else
                {
                    cities[nameOfTheCity].Population += populationOfTheCity;
                    cities[nameOfTheCity].Gold += goldOfTheCity;
                }
            }

            string events;
            while ((events = Console.ReadLine()) != "End")
            {
                string[] actions = events.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string actionType = actions[0];
                string cityName = actions[1];

                if (actionType == "Plunder")
                {
                    int numberOfPeople = int.Parse(actions[2]);
                    int goldAmount = int.Parse(actions[3]);

                    cities[cityName].Population -= numberOfPeople;
                    cities[cityName].Gold -= goldAmount;

                    Console.WriteLine($"{cityName} plundered! {goldAmount} gold stolen, {numberOfPeople} citizens killed.");

                    if (cities[cityName].Population == 0 || cities[cityName].Gold == 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");

                        cities.Remove(cityName);
                    }
                }
                else if (actionType == "Prosper")
                {
                    int goldAmount = int.Parse(actions[2]);

                    if (goldAmount >= 0)
                    {
                        cities[cityName].Gold += goldAmount;
                        Console.WriteLine($"{goldAmount} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }    
        }
    }
}

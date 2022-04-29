using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Plant
    {
        public Plant(int rare)
        {
            this.Rare = rare;
            this.Rate = new List<double>();
        }
        public int Rare { get; set; }

        public List<double> Rate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] plantInfo = input.Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (plants.ContainsKey(plantName))
                {
                    plants[plantName].Rare = rarity;
                }
                else
                {
                    plants.Add(plantName, new Plant(rarity));
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = command.Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                string plant = cmdArgs[1];

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }
                if (cmdType == "Rate")
                {
                    double rating = double.Parse(cmdArgs[2]);

                    plants[plant].Rate.Add(rating);
                }
                else if (cmdType == "Update")
                {
                    int newRarity = int.Parse(cmdArgs[2]);

                    plants[plant].Rare = newRarity;
                }
                else if (cmdType == "Reset")
                {
                    plants[plant].Rate.Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                double average = 0;

                if (plant.Value.Rate.Count > 0)
                {
                    average = plant.Value.Rate.Average();
                }

                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rare}; Rating: {average:f2}");
            }
        }
    }
}

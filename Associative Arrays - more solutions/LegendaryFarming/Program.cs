using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> craftingTable = new Dictionary<string, string>
            {
                { "shards", "Shadowmourne" },
                { "motes", "Dragonwrath" },
                { "fragments", "Valanyr" }
            };

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string obtainedItem = string.Empty;
            const int neededQuantityToCraft = 250;

            while (String.IsNullOrEmpty(obtainedItem)) // проверява дали подадения string, в случая obtainedItem е Null или Empty и връща true или false
            {
                string input = Console.ReadLine().ToLower();
                string[] inputLine = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < inputLine.Length; i += 2)
                {
                    int currentMaterialQuantity = int.Parse(inputLine[i]);
                    string currentMaterial = inputLine[i + 1];

                    if (keyMaterials.ContainsKey(currentMaterial))
                    {
                        keyMaterials[currentMaterial] += currentMaterialQuantity;

                        if (keyMaterials[currentMaterial] >= neededQuantityToCraft)
                        {
                            obtainedItem = craftingTable[currentMaterial];
                            keyMaterials[currentMaterial] -= neededQuantityToCraft;
                            
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currentMaterial))
                        {
                            junk[currentMaterial] = 0; // Работи както .Add - когато го няма този ключ го създава, задавайки му стойност 0, защото когато има равно е инициализация и вече не е getter a setter
                        }

                        junk[currentMaterial] += currentMaterialQuantity;
                    }
                }
            }

            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var material in keyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var junkMaterial in junk)
            {
                Console.WriteLine($"{junkMaterial.Key}: {junkMaterial.Value}");
            }
        }
    }
}

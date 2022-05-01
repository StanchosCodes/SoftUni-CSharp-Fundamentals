using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumsOrigin = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> drumSet = new List<int>();

            drumSet.AddRange(drumsOrigin);

            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;

                    if (drumSet[i] <= 0)
                    {
                        int currDrumPrice = drumsOrigin[i] * 3;

                        if (currDrumPrice <= budget)
                        {
                            drumSet[i] = drumsOrigin[i];
                            budget -= currDrumPrice;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumsOrigin.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}

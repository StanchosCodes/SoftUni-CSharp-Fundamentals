using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 1; i <= numberOfCommands; i++)
            {
                List<string> nameGoingOrNot = Console.ReadLine().Split().ToList();

                string name = nameGoingOrNot[0];

                if (nameGoingOrNot[2] == "not")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

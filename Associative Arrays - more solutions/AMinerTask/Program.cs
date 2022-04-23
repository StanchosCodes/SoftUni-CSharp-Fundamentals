using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string currentResource;
            while ((currentResource = Console.ReadLine()) != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(currentResource))
                {
                    resources[currentResource] += value;
                }
                else
                {
                    resources.Add(currentResource, value);
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}

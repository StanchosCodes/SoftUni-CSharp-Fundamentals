using System;
using System.Collections.Generic;
using System.Linq;

namespace CountReaNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> occurancies = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (occurancies.ContainsKey(number))
                {
                    occurancies[number] += 1;
                }
                else
                {
                    occurancies.Add(number, 1);
                }
            }

            foreach (var item in occurancies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

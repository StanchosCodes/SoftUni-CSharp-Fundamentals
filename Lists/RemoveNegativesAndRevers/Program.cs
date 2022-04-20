using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> positiveNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
            }

            positiveNumbers.Reverse();

            if (positiveNumbers.Count > 0)
            {
            Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}

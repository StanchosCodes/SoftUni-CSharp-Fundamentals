using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            while (firstList.Count > 0 && secondList.Count > 0)
            {
                resultList.Add(firstList.First());
                resultList.Add(secondList.Last());

                firstList.Remove(firstList.First());
                secondList.Remove(secondList.Last());
            }

            int lowestNum = 0;
            int biggestNum = 0;

            if (firstList.Count > 0)
            {
                lowestNum = firstList.Min();
                biggestNum = firstList.Max();
            }
            else
            {
                lowestNum = secondList.Min();
                biggestNum = secondList.Max();
            }

            List<int> finalList = new List<int>();

            foreach (int num in resultList.Where(x => x > lowestNum && x < biggestNum))
            {
                finalList.Add(num);
            }

            finalList.Sort();

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}

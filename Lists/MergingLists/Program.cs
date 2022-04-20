using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
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

            int biggerList = Math.Max(firstList.Count, secondList.Count); // Проверяваме кой от двата листа е по дълъг

            List<int> result = new List<int>();

            for (int i = 0; i < biggerList; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

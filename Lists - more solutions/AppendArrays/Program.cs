using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arraysSequence = Console.ReadLine()
                .Split('|')
                .ToList();

            string rawArray = "";

            for (int i = arraysSequence.Count - 1; i >= 0 ; i--)
            {
                rawArray += arraysSequence[i] + " ";
            }

            List<int> intOrderedList = rawArray
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", intOrderedList));
        }
    }
}

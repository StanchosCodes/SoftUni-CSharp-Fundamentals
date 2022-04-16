using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numToCheck = int.Parse(Console.ReadLine());

            int[] arrayToFill = new int[2];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == numToCheck)
                    {
                        arrayToFill[0] = array[i];
                        arrayToFill[1] = array[j];
                        Console.WriteLine(String.Join(" ", arrayToFill));
                    }
                }
            }
        }
    }
}

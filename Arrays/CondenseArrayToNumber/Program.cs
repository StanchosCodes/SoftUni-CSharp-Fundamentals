using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstArrayLenght = firstArray.Length;

            for (int i = 0; i < firstArrayLenght - 1; i++)
            {
                int[] condensedArray = new int[firstArray.Length - 1];

                for (int j = 0; j < firstArray.Length - 1; j++)
                {
                    condensedArray[j] = firstArray[j] + firstArray[j + 1];
                }

                firstArray = condensedArray;
            }

            Console.WriteLine(firstArray[0]);
        }
    }
}

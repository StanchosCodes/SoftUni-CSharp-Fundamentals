using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topArray = new int[array.Length];
            int topArrayIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topArray[topArrayIndex] = array[i];
                    topArrayIndex++;
                }
            }

            for (int i = 0; i < topArrayIndex; i++)
            {
                Console.Write($"{topArray[i]} ");
            }
        }
    }
}

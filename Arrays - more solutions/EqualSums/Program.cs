using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementIndex = 0;
            bool isEqual = false;

            for (int i = 0; i < array.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    elementIndex = i;
                    isEqual = true;
                }
            }

            if (isEqual)
            {
                Console.WriteLine(elementIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

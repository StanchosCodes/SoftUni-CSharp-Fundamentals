using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int equalCount = 0;
            int sequenceElement = 0;
            int leftmostSequenceCount = 0;
            int leftmostSequenceElement = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    sequenceElement = array[i];
                    equalCount++;
                }
                else
                {
                    equalCount = 0;
                }
                if (leftmostSequenceCount < equalCount)
                {
                    leftmostSequenceCount = equalCount;
                    leftmostSequenceElement = array[i];
                }
            }

            for (int j = 0; j <= leftmostSequenceCount; j++)
            {
                Console.Write($"{leftmostSequenceElement} ");
            }
        }
    }
}

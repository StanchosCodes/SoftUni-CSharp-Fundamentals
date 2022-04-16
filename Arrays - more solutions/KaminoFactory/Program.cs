using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfArrays = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int currentSequenceOfOnes = 0;
            int currentLongestSequenceOfOnes = 0;
            int currentEndIndex = 0;
            int dnaSampleCounter = 0;
            int currentSumOfOnes = 0;
            int bestSumOfOnes = 0;
            int longestSequenceOfOnes = -1;
            int startIndex = -1;
            int bestSampleIndex = 0;

            int[] bestArray = new int[lengthOfArrays];

            while (input != "Clone them!")
            {
                dnaSampleCounter++;

                int[] array = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currentSequenceOfOnes = 0;
                currentSumOfOnes = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        currentSequenceOfOnes++;
                        currentSumOfOnes++;
                        if (currentSequenceOfOnes >= currentLongestSequenceOfOnes)
                        {
                            currentLongestSequenceOfOnes = currentSequenceOfOnes;
                            currentEndIndex = i;
                        }
                    }
                    else
                    {
                        currentSequenceOfOnes = 0;
                    }
                }

                int currentStartIndex = 1 + (currentEndIndex - currentLongestSequenceOfOnes);

                bool isDnaBest = false;

                if (currentLongestSequenceOfOnes > longestSequenceOfOnes)
                {
                    isDnaBest = true;
                }
                else if (currentLongestSequenceOfOnes == longestSequenceOfOnes)
                {
                    if (currentStartIndex < startIndex)
                    {
                        isDnaBest = true;
                    }
                    else if (currentStartIndex == startIndex)
                    {
                        if (currentSumOfOnes > bestSumOfOnes)
                        {
                            isDnaBest = true;
                        }
                    }
                }

                if (isDnaBest)
                {
                    bestArray = array;
                    longestSequenceOfOnes = currentLongestSequenceOfOnes;
                    startIndex = currentStartIndex;
                    bestSumOfOnes = currentSumOfOnes;
                    bestSampleIndex = dnaSampleCounter;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSumOfOnes}.");
            Console.WriteLine(String.Join(" ", bestArray));
        }
    }
}

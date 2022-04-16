using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}

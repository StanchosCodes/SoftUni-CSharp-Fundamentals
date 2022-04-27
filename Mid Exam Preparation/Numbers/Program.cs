using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double average = nums.Average();
            nums.Sort();
            nums.Reverse();

            List<int> graterThenTheAverageNum = new List<int>();

            foreach (int num in nums)
            {
                if (graterThenTheAverageNum.Count < 5)
                {
                    if (num > average)
                    {
                        graterThenTheAverageNum.Add(num);
                    }
                }
            }

            if (graterThenTheAverageNum.Count > 0)
            {
            graterThenTheAverageNum.Sort();
            graterThenTheAverageNum.Reverse();

            Console.WriteLine(string.Join(" ", graterThenTheAverageNum));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

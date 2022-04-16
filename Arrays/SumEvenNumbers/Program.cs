﻿using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currentNum = nums[i];

            //    if (currentNum % 2 == 0)
            //    {
            //        sum += currentNum;
            //    }
            //}

            foreach (int currentNum in nums)
            {
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

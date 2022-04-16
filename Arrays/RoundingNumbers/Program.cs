using System;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] nums = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= -0.99 && nums[i] <= 0)
                {
                    nums[i] += 0;
                }
                Console.WriteLine($"{nums[i]} => {Math.Round(nums[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

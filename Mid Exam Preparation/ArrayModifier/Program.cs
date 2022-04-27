using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] commands = cmd.Split().ToArray();

                string typeOfTheCommand = commands[0];

                switch (typeOfTheCommand)
                {
                    case "swap":
                        int index1 = int.Parse(commands[1]);
                        int index2 = int.Parse(commands[2]);

                        int firstElement = nums[index1];
                        nums[index1] = nums[index2];
                        nums[index2] = firstElement;
                        break;
                    case "multiply":
                        index1 = int.Parse(commands[1]);
                        index2 = int.Parse(commands[2]);

                        nums[index1] *= nums[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums[i] -= 1;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}

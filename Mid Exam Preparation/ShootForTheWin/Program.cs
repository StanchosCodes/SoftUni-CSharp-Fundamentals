using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int countOfShotTargets = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                int index = int.Parse(cmd);

                if (index < 0 || index >= targets.Length)
                {
                    continue;
                }

                if (targets[index] != -1)
                {
                    int currentValue = targets[index];
                    targets[index] = -1;
                    countOfShotTargets++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] != -1 && targets[i] > currentValue)
                        {
                            targets[i] -= currentValue;
                        }
                        else if (targets[i] != -1 && targets[i] <= currentValue)
                        {
                            targets[i] += currentValue;
                        }
                    }
                 }
            }

            Console.WriteLine($"Shot targets: {countOfShotTargets} -> {string.Join(" ", targets)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombNumberAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNumber = bombNumberAndPower[0];
            int power = bombNumberAndPower[1];
            int indexOfTheBombNumber = -1;

            while (numbers.Contains(bombNumber))
            {

                if (numbers.Contains(bombNumber))
                {
                    indexOfTheBombNumber = numbers.FindIndex(x => x == bombNumber);
                }

                for (int i = 1; i <= power; i++)
                {
                    if (indexOfTheBombNumber > 0)
                    {
                    numbers.RemoveAt(indexOfTheBombNumber - 1);
                    indexOfTheBombNumber--;
                    }
                }

                for (int i = 1; i <= power; i++)
                {
                    if (indexOfTheBombNumber + 1 < numbers.Count)
                    {
                        numbers.RemoveAt(indexOfTheBombNumber + 1);
                    }
                }

                numbers.Remove(bombNumber);
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}

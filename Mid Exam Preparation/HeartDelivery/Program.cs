using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            int currentPosition = 0;

            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] jump = command.Split().ToArray();
                int jumpLength = int.Parse(jump[1]);

                if (jumpLength + currentPosition > neighborhood.Count - 1)
                {
                    currentPosition = 0;
                }
                else
                {
                    currentPosition += jumpLength;
                }
                if (neighborhood[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }
                if (neighborhood[currentPosition] > 0)
                {
                    neighborhood[currentPosition] -= 2;

                    if (neighborhood[currentPosition] <= 0)
                    {
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {currentPosition}.");

            int houseCount = 0;

            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] != 0)
                {
                    houseCount++;
                }
            }

            if (houseCount != 0)
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}

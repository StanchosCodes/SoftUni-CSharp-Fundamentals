using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> raceTrack = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            int finishLine = (raceTrack.Count - 1) / 2;

            for (int i = 0; i < finishLine; i++)
            {
                if (raceTrack[i] != 0)
                {
                    leftRacerTime += raceTrack[i];
                }
                else
                {
                    leftRacerTime *= 0.8;
                }
            }

            for (int i = raceTrack.Count - 1; i > finishLine; i--)
            {
                if (raceTrack[i] != 0)
                {
                    rightRacerTime += raceTrack[i];
                }
                else
                {
                    rightRacerTime *= 0.8;
                }
            }

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
        }
    }
}

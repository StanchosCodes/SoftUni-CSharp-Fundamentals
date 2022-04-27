using System;
using System.Linq;

namespace SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] routeCommands = Console.ReadLine()
                 .Split("||")
                 .ToArray();

            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < routeCommands.Length; i++)
            {
                string[] commands = routeCommands[i].Split().ToArray();
                string cmdType = commands[0];

                if (cmdType == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }

                int cmdValue = int.Parse(commands[1]);

                if (cmdType == "Travel")
                {
                    if (fuel >= cmdValue)
                    {
                        fuel -= cmdValue;
                        Console.WriteLine($"The spaceship travelled {cmdValue} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (cmdType == "Enemy")
                {
                    if (ammunition >= cmdValue)
                    {
                        ammunition -= cmdValue;
                        Console.WriteLine($"An enemy with {cmdValue} armour is defeated.");
                    }
                    else
                    {
                        if (fuel >= (cmdValue * 2))
                        {
                            fuel -= cmdValue * 2;
                            Console.WriteLine($"An enemy with {cmdValue} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }

                    }
                }
                else if (cmdType == "Repair")
                {
                    ammunition += cmdValue * 2;
                    fuel += cmdValue;

                    Console.WriteLine($"Ammunitions added: {cmdValue * 2}.");
                    Console.WriteLine($"Fuel added: {cmdValue}.");
                }
            }
        }
    }
}

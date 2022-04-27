using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');

            int health = 100;
            int bitcoins = 0;
            int bestRoomCounter = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i].Split();
                bestRoomCounter++;

                string roomType = currentRoom[0];
                int roomValue = int.Parse(currentRoom[1]);

                switch (roomType)
                {
                    case "potion":
                        int diff = 100 - health;
                        if (diff <= roomValue)
                        {
                            health += diff;
                            Console.WriteLine($"You healed for {diff} hp.");
                        }
                        else
                        {
                            health += roomValue;
                            Console.WriteLine($"You healed for {roomValue} hp.");
                        }
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += roomValue;
                        Console.WriteLine($"You found {roomValue} bitcoins.");
                        break;
                    default:
                        health -= roomValue;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {roomType}.");
                            Console.WriteLine($"Best room: {bestRoomCounter}");
                            Environment.Exit(0);
                        }
                        Console.WriteLine($"You slayed {roomType}.");
                        break;
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userAndLicencePlate = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string licencePlate = input[2];
                    if (userAndLicencePlate.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userAndLicencePlate[username]}");
                    }
                    else
                    {
                        userAndLicencePlate.Add(username, licencePlate);
                        Console.WriteLine($"{username} registered {licencePlate} successfully");
                    }
                }
                else
                {
                    if (!userAndLicencePlate.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        userAndLicencePlate.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var users in userAndLicencePlate)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }
        }
    }
}

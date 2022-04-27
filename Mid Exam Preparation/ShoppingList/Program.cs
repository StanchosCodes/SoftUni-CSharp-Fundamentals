using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split('!')
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command.Split().ToArray();

                string cmdType = cmdArgs[0];
                string item = cmdArgs[1];

                if (cmdType == "Urgent")
                {
                    if(!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (cmdType == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (cmdType == "Correct")
                {
                    string newItem = cmdArgs[2];

                    if (groceries.Contains(item))
                    {
                        int index = groceries.IndexOf(item);
                        groceries[index] = newItem;
                    }
                }
                else if (cmdType == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Add(item);
                        groceries.Remove(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}

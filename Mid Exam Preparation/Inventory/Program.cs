using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                List<string> cmdArgs = command.Split(" - ").ToList();

                string cmdType = cmdArgs[0];
                string value = cmdArgs[1];

                if (cmdType == "Collect")
                {
                    if (!items.Contains(value))
                    {
                        items.Add(value);
                    }
                }
                else if (cmdType == "Drop")
                {
                    if (items.Contains(value))
                    {
                        items.Remove(value);
                    }
                }
                else if (cmdType == "Combine Items")
                {
                    string combinedItems = cmdArgs[1];
                    List<string> combineItems = combinedItems.Split(':').ToList();
                    string firstItem = combineItems[0];
                    string secondItem = combineItems[1];

                    if (items.Contains(firstItem))
                    {
                        int indexOfTheItem = items.FindIndex(x => x.Contains(firstItem));
                        items.Insert(indexOfTheItem + 1, secondItem);
                    }
                }
                else if (cmdType == "Renew")
                {
                    if (items.Contains(value))
                    {
                        items.Add(value);
                        items.Remove(value);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> cmdArgs = command.Split().ToList();
                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int num = int.Parse(cmdArgs[1]);
                    numbers.Add(num);
                }
                else if (cmdType == "Insert")
                {
                    int num = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index <= numbers.Count - 1 && index >= 0)
                    {
                        numbers.Insert(index, num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdType == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index <= numbers.Count - 1 && index >= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdType == "Shift")
                {
                    int count = int.Parse(cmdArgs[2]);

                    if (cmdArgs[1] == "left")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.Remove(numbers[0]);
                        }
                    }
                    else if (cmdArgs[1] == "right")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
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
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> cmdArgs = command.Split().ToList();

                string cmdType = cmdArgs[0];
                int num = int.Parse(cmdArgs[1]);

                if (cmdType == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == num)
                        {
                            numbers.Remove(num);
                        }
                    }
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);

                    numbers.Insert(index, num);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

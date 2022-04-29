using System;

namespace StringGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Change")
                {
                    char oldChar = char.Parse(cmdArgs[1]);
                    char newChar = char.Parse(cmdArgs[2]);

                    input = input.Replace(oldChar, newChar);

                    Console.WriteLine(input);
                }
                else if (cmdType == "Includes")
                {
                    string textToCheck = cmdArgs[1];

                    Console.WriteLine(input.Contains(textToCheck));
                }
                else if (cmdType == "End")
                {
                    string textToCheck = cmdArgs[1];

                    Console.WriteLine(input.EndsWith(textToCheck));
                }
                else if (cmdType == "Uppercase")
                {
                    input = input.ToUpper();

                    Console.WriteLine(input);
                }
                else if (cmdType == "FindIndex")
                {
                    char charToFind = char.Parse(cmdArgs[1]);

                    int index = input.IndexOf(charToFind);

                    Console.WriteLine(index);
                }
                else if (cmdType == "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);

                    string cutText = input.Substring(startIndex, count);

                    Console.WriteLine(cutText);
                }
            }
        }
    }
}

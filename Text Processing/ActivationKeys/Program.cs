using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArgs[0];

                if (type == "Contains")
                {
                    string searchingString = cmdArgs[1];

                    if (rawInput.Contains(searchingString))
                    {
                        Console.WriteLine($"{rawInput} contains {searchingString}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                        continue;
                    }
                }
                else if (type == "Flip")
                {
                    string caseType = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int exclusiveEndIndex = int.Parse(cmdArgs[3]);

                    string textToFlip = rawInput.Substring(startIndex, exclusiveEndIndex - startIndex);

                    if (caseType == "Upper")
                    {
                        textToFlip = textToFlip.ToUpper();
                    }
                    else
                    {
                        textToFlip = textToFlip.ToLower();
                    }

                    rawInput = rawInput.Remove(startIndex, exclusiveEndIndex - startIndex);
                    rawInput = rawInput.Insert(startIndex, textToFlip);
                }
                else if (type == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int exclusiveEndIndex = int.Parse(cmdArgs[2]);

                    rawInput = rawInput.Remove(startIndex, exclusiveEndIndex - startIndex);
                }

                Console.WriteLine(rawInput);
            }

            Console.WriteLine($"Your activation key is: {rawInput}");
        }
    }
}

using System;
using System.Linq;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawPassword = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "TakeOdd")
                {
                    var oddChars = rawPassword.Where((character, index) => index % 2 != 0);
                    rawPassword = string.Join("", oddChars);

                    Console.WriteLine(rawPassword);
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    rawPassword = rawPassword.Remove(index, length);

                    Console.WriteLine(rawPassword);
                }
                else if (cmdType == "Substitute")
                {
                    string word = cmdArgs[1];
                    string replacingWord = cmdArgs[2];

                    if (rawPassword.Contains(word))
                    {
                        rawPassword = rawPassword.Replace(word, replacingWord);

                        Console.WriteLine(rawPassword);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {rawPassword}");
        }
    }
}

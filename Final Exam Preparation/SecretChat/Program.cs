using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptedMessage = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);

                    cryptedMessage = cryptedMessage.Insert(index, " ");
                }
                else if (cmdType == "Reverse")
                {
                    string words = cmdArgs[1];

                    if (cryptedMessage.Contains(words))
                    {
                        int indexOfWords = cryptedMessage.IndexOf(words);
                        cryptedMessage = cryptedMessage.Remove(indexOfWords, words.Length);
                        cryptedMessage = cryptedMessage + string.Join("", words.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (cmdType == "ChangeAll")
                {
                    string words = cmdArgs[1];
                    string replacementText = cmdArgs[2];

                    cryptedMessage = cryptedMessage.Replace(words, replacementText);
                }

                Console.WriteLine(cryptedMessage);
            }

            Console.WriteLine($"You have a new text message: {cryptedMessage}");
        }
    }
}

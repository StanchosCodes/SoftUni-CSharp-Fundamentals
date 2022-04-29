using System;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptedMessage = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Move")
                {
                    int lettersCount = int.Parse(cmdArgs[1]);

                    string textToMove = cryptedMessage.Substring(0, lettersCount);
                    cryptedMessage = cryptedMessage.Remove(0, lettersCount);
                    cryptedMessage = cryptedMessage + textToMove;
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string text = cmdArgs[2];

                    cryptedMessage = cryptedMessage.Insert(index, text);
                }
                else if (cmdType == "ChangeAll")
                {
                    string oldText = cmdArgs[1];
                    string newText = cmdArgs[2];

                    cryptedMessage = cryptedMessage.Replace(oldText, newText);
                }
            }

            Console.WriteLine($"The decrypted message is: {cryptedMessage}");
        }
    }
}

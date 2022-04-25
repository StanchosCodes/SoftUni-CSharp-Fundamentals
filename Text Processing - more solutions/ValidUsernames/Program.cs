using System;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> correctusernames = new List<string>();

            foreach (string currentUsername in usernames)
            {
                bool isCorect = false;

                if (currentUsername.Length >= 3 && currentUsername.Length <= 16)
                {
                    foreach (char currentChar in currentUsername)
                    {
                        if (char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_')
                        {
                            isCorect = true;
                        }
                        else
                        {
                            isCorect = false;
                            break;
                        }
                    }
                    if (isCorect)
                    {
                        correctusernames.Add(currentUsername);
                    }
                }
            }

            foreach (string username in correctusernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}

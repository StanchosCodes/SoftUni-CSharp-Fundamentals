using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            bool isCorrect = true;

            for (int wrongAtempts = 0; wrongAtempts <= 4;)
            {
                for (int i = username.Length - 1; i >= 0; i--)
                {
                    for (int j = password.Length - i - 1; j <= password.Length - 1;)
                    {
                        if (j >= 0 && username[i] == password[j])
                        {
                            break;
                        }
                        else
                        {
                            wrongAtempts++;
                            if (wrongAtempts == 4)
                            {
                                Console.WriteLine($"User {username} blocked!");
                                return;
                            }
                            Console.WriteLine("Incorrect password. Try again.");
                            isCorrect = false;
                            break;
                        }
                    }
                    if (isCorrect == false)
                    {
                        password = Console.ReadLine();
                        break;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        return;
                    }
                }
                isCorrect = true;
            }

        }
    }
}

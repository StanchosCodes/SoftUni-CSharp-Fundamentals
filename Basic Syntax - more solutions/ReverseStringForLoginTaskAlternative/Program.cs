using System;

namespace ReverseStringForLoginTaskAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string pass = Console.ReadLine();

            if (pass == password)
            {
                Console.WriteLine("Logged in!");
            }

            //Etc...
        }
    }
}

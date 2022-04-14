using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = "";

            for (int i = 0; i < 3; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                result += ch;
            }

            Console.WriteLine(result);
        }
    }
}

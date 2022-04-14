using System;

namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z') // ch >= 97 && ch <= 122
            {
                Console.WriteLine("lower-case");
            }
            else if (ch >= 'A' && ch <= 'Z') // ch >= 65 && ch <= 90
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}

using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{name1}{delimeter}{name2}");
        }
    }
}

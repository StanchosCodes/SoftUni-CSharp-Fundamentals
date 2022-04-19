using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddingCommand(num1, num2);
                    break;
                case "multiply":
                    MultiplyingCommand(num1, num2);
                    break;
                case "subtract":
                    SubtractingCommand(num1, num2);
                    break;
                case "divide":
                    DividingCommand(num1, num2);
                    break;
            }
        }
        static void AddingCommand(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void MultiplyingCommand(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void SubtractingCommand(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void DividingCommand(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}

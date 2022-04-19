using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNum, @operator, secondNum));
        }

        static double Calculate(double num1, string @operator, double num2)
        {
            double result = 0;
            switch(@operator)
            {
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
            }

            return result;
        }
    }
}

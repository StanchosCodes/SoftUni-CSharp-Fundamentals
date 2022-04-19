using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double firstResult = FactorialOfTheFirstNum(num1);
            double secondResult = FactorialOfTheFirstNum(num2);
            double finalResult = ResultOfTheDevision(firstResult, secondResult);

            Console.WriteLine($"{finalResult:f2}");

        }

        static double FactorialOfTheFirstNum(int firstNum)
        {
            double firstResult = firstNum;

            for (int i = 1; i < firstNum; i++)
            {
                firstResult *= i;
            }

            return firstResult;
        }

        static double FactorialOfTheSecondNum(int secondNum)
        {
            double secondResult = secondNum;

            for (int i = 1; i < secondNum; i++)
            {
                secondResult *= i;
            }

            return secondResult;
        }

        static double ResultOfTheDevision(double firstResult, double secondResult)
        {
            double finalResult = firstResult / secondResult;

            return finalResult;
        }
    }
}

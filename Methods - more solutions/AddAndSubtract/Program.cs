using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int addSum = Adding(num1, num2);
            int total = Subtracting(addSum, num3);

            Console.WriteLine(total);
        }

        static int Adding(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;

            return sum;
        }

        static int Subtracting(int addingSum, int thirdNum)
        {
            int totalSum = addingSum - thirdNum;

            return totalSum;
        }
    }
}

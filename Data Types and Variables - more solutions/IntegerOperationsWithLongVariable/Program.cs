using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long addResult = (long)firstNum + secondNum;
            long devideResult = addResult / thirdNum;
            long multipyResult = devideResult * fourthNum;

            Console.WriteLine(multipyResult);
        }
    }
}

using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Comparing(num1, num2, num3));
        }

        static int Comparing(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                return first;
            }
            else if (second < first && second < third)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}

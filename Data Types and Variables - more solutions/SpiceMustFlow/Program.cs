using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int dayCount = 0;
            int amount = 0;

            if (yield < 100)
            {
                Console.WriteLine(dayCount);
                Console.WriteLine(amount);
            }
            else
            {
            while (yield >= 100)
            {
                amount += yield;
                yield -= 10;
                dayCount++;
            }

            if (yield < 100)
            {
                amount -= (dayCount + 1) * 26;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(amount);
            }

        }
    }
}

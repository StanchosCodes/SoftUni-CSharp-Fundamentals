using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhoustFactor = int.Parse(Console.ReadLine());

            int power = originalPower;
            int pockedCount = 0;

            while (power >= distance)
            {
                power -= distance;

                if (power == (decimal) originalPower / 2)
                {
                    if (exhoustFactor != 0)
                    {
                        power /= exhoustFactor;
                    }
                }

                pockedCount++;
            }

            if (power < distance)
            {
                Console.WriteLine(power);
                Console.WriteLine(pockedCount);
            }
        }
    }
}

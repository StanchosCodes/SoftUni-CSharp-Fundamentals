using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tank = 0;

            for (int i = 0; i < n; i++)
            {
            int littresWater = int.Parse(Console.ReadLine());

                if (tank + littresWater <= 255)
                {
                    tank += littresWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(tank);


        }
    }
}

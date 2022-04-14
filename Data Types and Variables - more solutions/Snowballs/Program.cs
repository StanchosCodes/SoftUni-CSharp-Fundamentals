using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsQuntity = int.Parse(Console.ReadLine());

            int snow = 0;
            int time = 0;
            int quality = 0;
            BigInteger value = BigInteger.Zero;

            for (int i = 0; i < snowballsQuntity; i++)
            {
                int currentSnow = int.Parse(Console.ReadLine());
                int currentTime = int.Parse(Console.ReadLine());
                int currentQuality = int.Parse(Console.ReadLine());

                int devide = currentSnow / currentTime;
                BigInteger currentValue = BigInteger.Pow(devide, currentQuality);

                if (currentValue <= value)
                {
                    continue;
                }

                snow = currentSnow;
                time = currentTime;
                quality = currentQuality;
                value = currentValue;
            }

            Console.WriteLine($"{snow} : {time} = {value} ({quality})");
        }
    }
}

using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double volume = 0;
            string model = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentVolume > volume)
                {
                    model = currentModel;
                    volume = currentVolume;
                }
            }

            Console.WriteLine(model);
        }
    }
}

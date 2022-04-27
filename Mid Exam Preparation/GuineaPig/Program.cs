using System;

namespace GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double foodInGrams = food * 1000;
            double hayInGrams = hay * 1000;
            double coverInGrams = cover * 1000;
            double weightInGrams = weight * 1000;

            for (int day = 1; day <= 30; day++)
            {
                foodInGrams -= 300;

                if (day % 2 == 0)
                {
                    hayInGrams -= foodInGrams * 0.05;
                }
                if (day % 3 == 0)
                {
                    coverInGrams -= weightInGrams / 3;
                }

                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            if (foodInGrams > 0 || hayInGrams > 0 || coverInGrams > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGrams / 1000:f2}, Hay: {hayInGrams / 1000:f2}, Cover: {coverInGrams / 1000:f2}.");
            }
        }
    }
}

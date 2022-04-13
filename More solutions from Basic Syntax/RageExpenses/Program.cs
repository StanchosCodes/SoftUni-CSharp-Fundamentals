using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            int lostGamesCount = 0;

            for (int i = 0; i < lostGames; i++)
            {
                lostGamesCount++;

                if (lostGamesCount % 2 == 0)
                {
                    headsetCount++;
                }
                if (lostGamesCount % 3 == 0)
                {
                    mouseCount++;
                }
                if (lostGamesCount % 6 == 0)
                {
                    keyboardCount++;
                }
                if (lostGamesCount % 12 == 0)
                {
                    displayCount++;
                }
            }

            double totalCost = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}

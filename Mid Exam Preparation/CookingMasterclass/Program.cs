using System;

namespace CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double singleFlourPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double singleApronPrice = double.Parse(Console.ReadLine());

            int freeFlour = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freeFlour++;
                }
            }

            double neededFloursPrice = singleFlourPrice * (students - freeFlour);
            double neededEggsPrice = singleEggPrice * (students * 10);
            double neededApronsPrice = singleApronPrice * Math.Ceiling(students * 1.2);

            double totalNeededMoney = neededApronsPrice + neededEggsPrice + neededFloursPrice;

            if (totalNeededMoney <= budget)
            {
                Console.WriteLine($"Items purchased for {totalNeededMoney:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalNeededMoney - budget:f2}$ more needed.");
            }
        }
    }
}

using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double priceForOnePerson = 0;
            double totalSum = 0;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        priceForOnePerson = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        priceForOnePerson = 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        priceForOnePerson = 10.46;
                    }
                    totalSum = priceForOnePerson * peopleCount;
                    if (peopleCount >= 30)
                    {
                        totalSum *= 0.85;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        priceForOnePerson = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        priceForOnePerson = 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        priceForOnePerson = 16;
                    }
                    totalSum = peopleCount * priceForOnePerson;
                    if (peopleCount >= 100)
                    {
                        totalSum = priceForOnePerson * (peopleCount - 10);
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        priceForOnePerson = 15;
                    }
                    else if (day == "Saturday")
                    {
                        priceForOnePerson = 20;
                    }
                    else if (day == "Sunday")
                    {
                        priceForOnePerson = 22.50;
                    }
                    totalSum = peopleCount * priceForOnePerson;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalSum *= 0.95;
                    }
                    break;
            }
                    Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}

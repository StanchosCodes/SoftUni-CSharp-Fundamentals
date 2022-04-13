using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double currentOrderPrice = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                currentOrderPrice = days * capsulesCount * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:f2}");
                totalPrice += currentOrderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

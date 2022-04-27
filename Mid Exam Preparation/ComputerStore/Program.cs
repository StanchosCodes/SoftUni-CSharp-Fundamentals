using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            string order;
            while ((order = Console.ReadLine()) != "special" && order != "regular")
            {
                if (double.Parse(order) >= 0)
                {
                    price += double.Parse(order);
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
            }
            if (price > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");

                double taxes = price * 0.20;
                double priceWithTaxes = price + taxes;

                Console.WriteLine($"Price without taxes: {price:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                
                if (order == "special")
                {
                    double totalPrice = priceWithTaxes * 0.90;

                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
                }
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}

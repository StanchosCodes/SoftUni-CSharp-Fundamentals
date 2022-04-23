using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> productAndQuantity = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] commandArgs = command.Split().ToArray();
                string currProductName = commandArgs[0];
                double currProductPrice = double.Parse(commandArgs[1]);
                int currProductQuantity = int.Parse(commandArgs[2]);

                if (!productAndPrice.ContainsKey(currProductName))
                {
                    productAndPrice[currProductName] = 0;
                    productAndQuantity[currProductName] = 0;
                }

                if (productAndPrice[currProductName] != currProductPrice)
                {
                    productAndPrice[currProductName] = currProductPrice;
                }
                productAndQuantity[currProductName] += currProductQuantity;
            }

            foreach (var product in productAndPrice)
            {
                string productKey = product.Key;

                double totalPrice = product.Value * productAndQuantity[productKey];

                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}

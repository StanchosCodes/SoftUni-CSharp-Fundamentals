using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            List<string> purchases = new List<string>();
            decimal totalPrice = 0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match currMatch = Regex.Match(input, pattern);

                if (currMatch.Success)
                {
                    string currProduct = currMatch.Groups["furniture"].Value;
                    decimal currProductPrice = decimal.Parse(currMatch.Groups["price"].Value);
                    int currQuantity = int.Parse(currMatch.Groups["quantity"].Value);

                    purchases.Add(currProduct);
                    totalPrice += currProductPrice * currQuantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (string item in purchases)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}

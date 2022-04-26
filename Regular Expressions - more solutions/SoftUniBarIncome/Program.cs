using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customerName>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

            decimal totalIncome = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match currPurchase = Regex.Match(input, pattern);

                if (currPurchase.Success)
                {
                    string currCustomer = currPurchase.Groups["customerName"].Value;
                    string currProduct = currPurchase.Groups["product"].Value;
                    int currQuantity = int.Parse(currPurchase.Groups["quantity"].Value);
                    decimal currPrice = decimal.Parse(currPurchase.Groups["price"].Value);

                    Console.WriteLine($"{currCustomer}: {currProduct} - {currQuantity * currPrice:f2}");
                    totalIncome += currQuantity * currPrice;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currBarcode = Console.ReadLine();

                string cleanBarcode = currBarcode.Replace("@", "");
                cleanBarcode = currBarcode.Replace("#", "");

                if (cleanBarcode.Length < 6)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string productGroup = string.Empty;

                    Match currMatch = Regex.Match(currBarcode, pattern);

                    if (currMatch.Success)
                    {
                        Regex digitsPattern = new Regex(@"\d");

                        MatchCollection digitMatches = digitsPattern.Matches(currBarcode);

                        StringBuilder productDigits = new StringBuilder();

                        foreach (Match digit in digitMatches)
                        {
                            productDigits.Append(digit);
                        }

                        if (productDigits.Length == 0)
                        {
                            productGroup = "00";
                        }
                        else
                        {
                            productGroup = productDigits.ToString();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid barcode");
                        continue;
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
            }
        }
    }
}

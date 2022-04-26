using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> demons = Console.ReadLine()
                .Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(n => n)
                .ToList();

            string digitsPattern = @"[+-]?\d+(\.\d+)?";
            string symbolsPattern = @"[*/]";

            foreach (string demon in demons)
            {
                int currDemonHealth = 0;
                double currDemonDamage = 0;

                foreach (char ch in demon)
                {
                    if (!char.IsDigit(ch) && ch != '+' && ch != '-' && ch != '/' && ch != '*' && ch != '.')
                    {
                        currDemonHealth += ch;
                    }
                }

                MatchCollection currDemonDigitsMatches = Regex.Matches(demon, digitsPattern);
                MatchCollection currDemonSymbolsMatches = Regex.Matches(demon, symbolsPattern);

                foreach (Match digit in currDemonDigitsMatches)
                {
                    currDemonDamage += double.Parse(digit.ToString());
                }

                foreach (Match symbol in currDemonSymbolsMatches)
                {
                    string currSymbol = symbol.ToString();

                    if (currSymbol == "/")
                    {
                        currDemonDamage /= 2;
                    }
                    else if (currSymbol == "*")
                    {
                        currDemonDamage *= 2;
                    }
                }

                Console.WriteLine($"{demon} - {currDemonHealth} health, {currDemonDamage:f2} damage");
            }
        }
    }
}

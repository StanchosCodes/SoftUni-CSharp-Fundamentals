using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumberPattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string phoneNumbers = Console.ReadLine();

            MatchCollection phoneNumberMatches = Regex.Matches(phoneNumbers, phoneNumberPattern);
            List<string> listPhoneNumbers = new List<string>();

            foreach (Match number in phoneNumberMatches)
            {
                listPhoneNumbers.Add(number.Value);
            }

            Console.WriteLine(string.Join(", ", listPhoneNumbers));
        }
    }
}

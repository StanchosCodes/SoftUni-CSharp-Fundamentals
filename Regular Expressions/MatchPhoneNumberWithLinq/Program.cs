using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumberPattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string phoneNumbers = Console.ReadLine();

            string[] phoneNumberMatches = Regex
                .Matches(phoneNumbers, phoneNumberPattern)
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", phoneNumberMatches));
        }
    }
}

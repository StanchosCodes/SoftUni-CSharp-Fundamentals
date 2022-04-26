using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Regex emailValidationPattern = new Regex(@"(^|(?<=\s))(([A-Za-z0-9]+)([\.\-\w]*)@([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))");

            MatchCollection validEmails = emailValidationPattern.Matches(inputLine);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}

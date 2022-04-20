using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(x => x < 0); //  Маха всички числа по - малки от 0 - (х) е число от листа; минава през всички числа от листа и проверява дали х е по - малко от 0 и го маха; условието може да е всякакво като за if проверка; също така (х) може да е и някоя променлива; която имаме, тоест не е задължително да е х
            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

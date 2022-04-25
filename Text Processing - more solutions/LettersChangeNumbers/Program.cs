using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateASingleWordSum(word);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateASingleWordSum (string word)
        {
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            decimal sum = 0;

            int firstLetterPosition = PositionOfTheLetter(firstLetter);
            int lastLetterPosition = PositionOfTheLetter(lastLetter);

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal) num / firstLetterPosition;
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal) num * firstLetterPosition;
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }

            return sum;
        }

        static int PositionOfTheLetter (char letter)
        {
            char letterCaseInsensitive = char.ToLower(letter);

            return (int)letterCaseInsensitive - 96;
        }
    }
}

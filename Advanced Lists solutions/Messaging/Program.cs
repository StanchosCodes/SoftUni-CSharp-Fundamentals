using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string sentence = Console.ReadLine();

            string output = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                string currentNum = numbers[i];
                int currIndex = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    currIndex += int.Parse(currentNum[j].ToString());
                }

                while (currIndex >= sentence.Length)
                {
                    currIndex -= sentence.Length;
                }

                output += sentence[currIndex];
                sentence = sentence.Remove(currIndex, 1);

            }

            Console.WriteLine(output);
        }
    }
}

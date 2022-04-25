using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstString = strings[0];
            string secondString = strings[1];
            int sum = 0;

            if (firstString.Length == secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
            }
            else
            {
                if (firstString.Length > secondString.Length)
                {
                    for (int i = 0; i < secondString.Length; i++)
                    {
                        sum += firstString[i] * secondString[i];
                    }

                    for (int j = secondString.Length; j < firstString.Length; j++)
                    {
                        sum += firstString[j];
                    }
                }
                else
                {
                    for (int i = 0; i < firstString.Length; i++)
                    {
                        sum += firstString[i] * secondString[i];
                    }

                    for (int j = firstString.Length; j < secondString.Length; j++)
                    {
                        sum += secondString[j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}

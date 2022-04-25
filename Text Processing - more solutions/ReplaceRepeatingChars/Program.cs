using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i == sequence.Length - 1)
                {
                    break;
                }
                if (sequence[i] == sequence[i + 1])
                {
                    sequence = sequence.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(sequence);
        }
    }
}

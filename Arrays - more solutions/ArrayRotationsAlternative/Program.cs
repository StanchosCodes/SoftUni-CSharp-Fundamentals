using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int reducedRotations = rotations % arr.Length; // to reduce the rotations and ease the program

            for (int i = 0; i < reducedRotations; i++)
            {
                int zeroElementOfTheArray = arr[0];

                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = zeroElementOfTheArray;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

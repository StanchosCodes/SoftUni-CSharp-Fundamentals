using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfWagons = int.Parse(Console.ReadLine());

            int[] peopleInTheWagons = new int[quantityOfWagons];

            int sum = 0;

            for (int i = 0; i < peopleInTheWagons.Length; i++)
            {
                peopleInTheWagons[i] = int.Parse(Console.ReadLine());
                Console.Write(peopleInTheWagons[i] + " ");
                sum += peopleInTheWagons[i];
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            MatrixCreating(num);
        }

        static void MatrixCreating(int number)
        {
            for (int columns = 0; columns < number; columns++)
            {
                for (int rows = 0; rows < number; rows++)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine();
            }
        }
    }
}

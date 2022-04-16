using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries) // разделя елементите от масива по празно място и също ако има излишни празни места ги премахва
                    .Select(int.Parse) // парсва всеки елемент подаден от сплита към интеджер
                    .ToArray(); // понеже след селект  функцията това вече не е масив, .ToArray ги връща в масив

                int firstNum = currentRow[0];
                int secondNum = currentRow[1];

                if (row % 2 == 0)
                {
                    array1[row - 1] = secondNum;
                    array2[row - 1] = firstNum;
                }
                else
                {
                    array1[row - 1] = firstNum;
                    array2[row - 1] = secondNum;
                }

            }
            Console.WriteLine(String.Join(" ", array1)); // Отпечатва масива с разделител спейс
            Console.WriteLine(String.Join(" ", array2)); // отпечатва масива с разделител спейс
        }
    }
}

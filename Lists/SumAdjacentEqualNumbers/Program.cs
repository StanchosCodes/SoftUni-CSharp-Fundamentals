using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine() // Четем листа от конзолата
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)  // Въртим от 0 до дължината на листа - 1
            {
                if (numbers[i] == numbers[i + 1])  // Проверяваме дали символа на позиция i  е равен на символа на позиция i + 1 (тоест дали е равен на следващия символ)
                {
                    numbers[i] += numbers[i + 1]; // След това събираме двата символа и презаписаме стойността върху тази на символа на позиция i 
                    numbers.RemoveAt(i + 1); // Премахваме съседния символ защото той вече не ни трябва
                    i = -1; // Зануляваме брояча на цикъла, за да проверяваме дали събраната сума е равна на съседното число
                }
            }

            Console.WriteLine(string.Join(" ", numbers)); // Отпечатваме листа със разстояние за разделител
        }
    }
}

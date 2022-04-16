using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); // чете масив от конзолата и го подрежда по индекси, просто вместо да въртим цикъл за да наместим всеки елемент по индексите на масива го правим с .Split() функцията примерно: 10 20 30 40 -> [0] - 10 [1] 20 [2] 30 [3] 40

            Array.Reverse(input); // Функция, която обръща масива автоматично

            Console.WriteLine(string.Join(" ", input)); // join - функция, която ни позволява да изредим елементите от масива с интервал или каквото поискаме (някакъв сепаратор) (аналогично е на for цикъл, но по - кратко и по - лесно)
        }
    }
}

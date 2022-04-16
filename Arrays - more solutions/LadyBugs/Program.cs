using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugsIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize]; // нов масив, който да пази местата където има калинки и където няма
            for (int index = 0; index < fieldSize; index++)
            {
                if (ladybugsIndexes.Contains(index)) // Проверява дали индекса се съдържа в ladybugsIndexes
                {
                    field[index] = 1; // ако индекса се съдържа това значи че там има калинка и го отбелязваме с 1-ца; ако няма си остава 0, понеже по подразбиране си е 0 индекса в масива
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end") // лесен начин за прочитане на команда в цикъла
            {
                string[] cmdArgs = command // преобразуване на командата в стринг масив
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialIndex = int.Parse(cmdArgs[0]); // записваме си стойностите от масива понеже знаем че те винаги ще са в този ред и от такъв тип
                string direction = cmdArgs[1]; // -//-
                int flyLength = int.Parse(cmdArgs[2]); // -//-

                // Проверяваме дали индекса е валиден, тоест дали е в диапазона на цикъла. Винаги първо това се проверява
                if (initialIndex < 0 || initialIndex >= field.Length)
                {
                    // прескачаме тази итерация и отиваме към следващата, защото индекса не е в диапазона на масива, иначе ще гръмне че е излязло извън цикъла
                    continue;
                }

                // Щом сме стигнали до тук без да влезем в горната проверка, това значи че индекса е валиден и сега проверяваме дали на този индекс има или няма калинка
                if (field[initialIndex] == 0)
                {
                    //щом няма калинка продължаваме към следващата итерация на цикъла
                    continue;
                }

                // щом сме стигнали до тук без да влезем в горните проверки значи можем да излетим
                // променяме мястото на initialIndex - a на 0 защото калинката е излетяла и там вече няма калинка, мястото е празно
                field[initialIndex] = 0;

                // сега трябва да изчислим кой е следващия индекс

                int nextIndex = initialIndex; // записваме му стойността на initialIndex и сега ще добавяме размера на flyLength - а

                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength; // калинката започва да лети надясно в цикъла
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLength; // изваждаме за да може стойността да стане отрицателна и калинката да започне да лети наляво в цикъла
                    }

                    // сега проверяваме дали калинката ще остане в полето или ще излети извън него и ще изезне
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        // калинката вече не е на никой индекс в масива, излетяла е извън него и прекъсваме цикъла защото няма да се върти повече
                        break;
                    }
                    // сега проверяваме дали калинката може да кацне
                    if (field[nextIndex] == 0)
                    {
                        // мястото на този индекс е празно и калинката може да кацне и прекъсваме цикъла, защото нямаме нужда да се върти повече
                        break;
                    }
                }
                // сега запълваме позицията където е кацнала калинката с 1 - ца за да можем да отбележим че мястото вече е заето
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }

            Console.WriteLine(string.Join(" ", field)); // отпечатваме масива който съдържа информация къде има калинка и къде няма посредством 1 - ци за където има и 0 - ли за където няма
        }
    }
}

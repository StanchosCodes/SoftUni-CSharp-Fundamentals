using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheVeriables = Console.ReadLine();

            if (typeOfTheVeriables == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (typeOfTheVeriables == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (typeOfTheVeriables == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            return (first > second) ? first : second; // тернарен израз - заместител на if else (? - if) (: - else)
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0) // .CompareTo сравнява 2 стринга и връща 0 ако първия е по голям от втория (има описание като ховърнеш върху .CompareTo)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}

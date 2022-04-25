using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string wholeString = Console.ReadLine();

            while (wholeString.Contains(wordToRemove))
            {
                wholeString = wholeString.Replace(wordToRemove, ""); // заменя подадената дума колкото пъти я има в думата, която му казваме да заменя с то това което му кажем, като в случая е празен стринг, защото искаме просто да я махнем
            }

            Console.WriteLine(wholeString);
        }
    }
}

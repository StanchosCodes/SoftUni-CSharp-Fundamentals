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
                int indexOfTheWordToRemove = wholeString.IndexOf(wordToRemove); // връща индекса на първия символ в думата, която търсим
                wholeString = wholeString.Remove(indexOfTheWordToRemove, wordToRemove.Length); // подаваме му индекса, от който искаме да започнем да махаме и броя на символите, които искаме да махнем, като в случая е дулжината на думата, която махаме
            }

            Console.WriteLine(wholeString);
        }
    }
}

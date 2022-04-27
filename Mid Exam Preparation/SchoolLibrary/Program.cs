using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bookShelf = Console.ReadLine()
                .Split('&')
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandsAndBooks = command
                    .Split(" | ")
                    .ToArray();

                string cmdType = commandsAndBooks[0];

                if (cmdType == "Add Book")
                {
                    string bookName = commandsAndBooks[1];

                    if (!bookShelf.Contains(bookName))
                    {
                        bookShelf.Insert(0, bookName);
                    }
                }
                else if (cmdType == "Take Book")
                {
                    string bookName = commandsAndBooks[1];

                    if (bookShelf.Contains(bookName))
                    {
                        bookShelf.Remove(bookName);
                    }
                }
                else if (cmdType == "Swap Books")
                {
                    string firstBookName = commandsAndBooks[1];
                    string secondBookName = commandsAndBooks[2];

                    if (bookShelf.Contains(firstBookName) && bookShelf.Contains(secondBookName))
                    {
                        int firstBookIndex = bookShelf.FindIndex(x => x == firstBookName);
                        int secondBookIndex = bookShelf.FindIndex(x => x == secondBookName);

                        bookShelf[firstBookIndex] = secondBookName;
                        bookShelf[secondBookIndex] = firstBookName;
                    }
                }
                else if (cmdType == "Insert Book")
                {
                    string bookName = commandsAndBooks[1];

                    if (!bookShelf.Contains(bookName))
                    {
                        bookShelf.Add(bookName);
                    }
                }
                else if (cmdType == "Check Book")
                {
                    int indexOfTheBook = int.Parse(commandsAndBooks[1]);

                    if (indexOfTheBook >= 0 && indexOfTheBook < bookShelf.Count)
                    {
                        Console.WriteLine(bookShelf[indexOfTheBook]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", bookShelf));
        }
    }
}

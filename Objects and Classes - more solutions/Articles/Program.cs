using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            int numberOfCommands = int.Parse(Console.ReadLine());

            string title = article[0];
            string content = article[1];
            string author = article[2];

            Article newArticle = new Article(title, content, author);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                string cmd = commands[0];
                string newValue = commands[1];

                if (cmd == "Edit")
                {
                    newArticle.Content = newValue;
                }
                else if (cmd == "ChangeAuthor")
                {
                    newArticle.Author = newValue;
                }
                else if (cmd == "Rename")
                {
                    newArticle.Title = newValue;
                }
            }
            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }
    }
}

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
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] article = Console.ReadLine().Split(", ");

                string title = article[0];
                string content = article[1];
                string author = article[2];

                Article newArticle = new Article(title, content, author);
                articles.Add(newArticle);
            }

            string command = Console.ReadLine();

            List<Article> orderedArticles = new List<Article>();

            if (command == "title")
            {
                orderedArticles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (command == "content")
            {
                orderedArticles = articles.OrderBy(a => a.Content).ToList();
            }
            else if (command == "author")
            {
                orderedArticles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (Article article in orderedArticles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}

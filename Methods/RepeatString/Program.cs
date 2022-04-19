using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatingTheTemplate(template, repeatCount));
        }

        static string RepeatingTheTemplate(string template, int count)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(template);
            }

            return stringBuilder.ToString();
        }
    }
}

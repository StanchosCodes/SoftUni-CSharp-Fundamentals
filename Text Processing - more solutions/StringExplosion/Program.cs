using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int explosionStrenth = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    explosionStrenth += (int.Parse(Convert.ToString(line[i + 1])));

                    continue;
                }

                if (explosionStrenth > 0)
                {
                    line = line.Remove(i, 1);
                    explosionStrenth--;
                    i--;
                }
            }

            Console.WriteLine(line);
        }
    }
}

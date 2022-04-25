using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string fileNameAndExtensin = path.Last();

            string[] fileNameAndExtasionArr = fileNameAndExtensin.Split('.');

            string fileName = fileNameAndExtasionArr[0];
            string extansion = fileNameAndExtasionArr[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extansion}");
        }
    }
}

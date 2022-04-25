using System;
using System.Diagnostics;
using System.Text;

namespace StopWatchClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch sw = new Stopwatch();

            //sw.Start();
            //string text = string.Empty;
            //for (int i = 0; i <= 200000; i++)
            //{
            //    text += i;
            //}
            //sw.Stop();

            //Console.WriteLine(sw.ElapsedMilliseconds); // Отнема супер много време - няколко минути

            Stopwatch sw = new Stopwatch();

            sw.Start();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= 200000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds); // Отнема 26 милисекунди...
        }
    }
}

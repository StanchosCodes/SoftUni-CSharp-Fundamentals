using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek =
            {
                "Monday", //[0]
                "Tuesday", //[1]
                "Wednesday", //[2]
                "Thursday", //[3]
                "Friday", //[4]
                "Saturday", //[5]
                "Sunday" //[6]
            };

            if (dayNum >= 1 && dayNum <= daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[dayNum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

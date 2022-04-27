using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsQuestions = int.Parse(Console.ReadLine());

            int answeredQestionsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int neededHours = 0;
            bool isAllQuestionsAnswered = false;

            while (studentsQuestions > 0)
            {
                for (int i = 1; i <= 3; i++)
                {
                    studentsQuestions -= answeredQestionsPerHour;
                    neededHours++;
                    if (studentsQuestions <= 0)
                    {
                        isAllQuestionsAnswered = true;
                        break;
                    }
                }
                if (isAllQuestionsAnswered)
                {
                    break;
                }
                neededHours++;
            }

            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}

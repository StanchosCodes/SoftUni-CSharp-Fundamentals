using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double numberOfTheLectures = double.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            double currentAttendaces = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                double currentBonus = attendances / numberOfTheLectures * (5 + additionalBonus);

                if (currentBonus > totalBonus)
                {
                    totalBonus = currentBonus;
                    currentAttendaces = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {currentAttendaces} lectures.");
        }
    }
}

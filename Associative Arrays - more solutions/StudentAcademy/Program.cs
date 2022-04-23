using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            const double minAverageGrade = 4.50;

            Dictionary<string, List<double>> studentsAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(student))
                {
                    studentsAndGrades.Add(student, new List<double> { grade });
                }
                else
                {
                studentsAndGrades[student].Add(grade);
                }
            }

            foreach (var student in studentsAndGrades)
            {
                if (student.Value.Average() >= minAverageGrade)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}

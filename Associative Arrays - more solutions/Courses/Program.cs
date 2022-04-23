using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesAndStudents = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string courseName = commandArgs[0];
                string student = commandArgs[1];

                if (!coursesAndStudents.ContainsKey(courseName))
                {
                    coursesAndStudents.Add(courseName, new List<string> { student });
                }
                else
                {
                    coursesAndStudents[courseName].Add(student);
                }
            }

            foreach (var course in coursesAndStudents)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"-- {course.Value[i]}");
                }
            }
        }
    }
}

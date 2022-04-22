using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] nextStudent = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string currFirstName = nextStudent[0];
                string currLastName = nextStudent[1];
                double currGrade = double.Parse(nextStudent[2]);

                Student currentStudent = new Student(currFirstName, currLastName, currGrade);

                students.Add(currentStudent);
            }

            List<Student> orderedStudents = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}

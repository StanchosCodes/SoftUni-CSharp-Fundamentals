using System;
using System.Collections.Generic;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();

                string theFirstName = cmdArgs[0];
                string theLastName = cmdArgs[1];
                int theAge = int.Parse(cmdArgs[2]);
                string theHomeTown = cmdArgs[3];

                Student newStudent = new Student();

                newStudent.FirstName = theFirstName;
                newStudent.LastName = theLastName;
                newStudent.Age = theAge;
                newStudent.HomeTown = theHomeTown;

                bool isStudentExisting = false;
                Student currentStudent = null;

                foreach (Student student in students)
                {
                    if (student.FirstName == theFirstName && student.LastName == theLastName)
                    {
                        currentStudent = students.Find(student => student.FirstName == theFirstName && student.LastName == theLastName);
                        isStudentExisting = true;
                    }
                }
                if (!isStudentExisting)
                {
                    students.Add(newStudent);
                }
                else
                {
                    students.Remove(currentStudent);
                    students.Add(newStudent);
                }
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudentsList = students.FindAll(student => student.HomeTown == cityName);

            foreach (Student name in filteredStudentsList)
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} is {name.Age} years old.");
            }
        }
    }
}
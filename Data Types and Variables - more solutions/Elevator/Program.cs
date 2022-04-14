using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            if (peopleCount % elevatorCapacity == 0)
            {
                Console.WriteLine(peopleCount / elevatorCapacity);
            }
            else
            {
                int fullCourses = peopleCount / elevatorCapacity;
                int allCourses = fullCourses + 1; // because int leftoverCourse = peopleCount - (fullCourses * elevatorCapacity); witch adds only 1 more course

                Console.WriteLine(allCourses);
            }
        }
    }
}

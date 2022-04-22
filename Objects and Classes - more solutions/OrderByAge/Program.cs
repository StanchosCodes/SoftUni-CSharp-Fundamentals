using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class People
    {
        public People(string name, int id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<People> allPeople = new List<People>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] peopleArgs = input.Split();

                string name = peopleArgs[0];
                int id = int.Parse(peopleArgs[1]);
                int age = int.Parse(peopleArgs[2]);

                People newName = new People(name, id, age);

                if (allPeople.Any(i => i.ID == id))
                {
                    People currentPerson = allPeople.Find(i => i.ID == id);

                    currentPerson.Name = name;
                    currentPerson.Age = age;

                    continue;
                }

                allPeople.Add(newName);
            }

            foreach (People people in allPeople.OrderBy(p => p.Age))
            {
                Console.WriteLine(people);
            }
        }
    }
}

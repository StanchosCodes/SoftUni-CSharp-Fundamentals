using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipultionBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] cmdArgs = new string[] {};

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                cmdArgs = command.Split();
                string cmdType = cmdArgs[0];
                int numberOrIndex = int.Parse(cmdArgs[1]);

                if (cmdType == "Add")
                {
                    AddingInTheList(numbers, numberOrIndex);
                }
                else if (cmdType == "Remove")
                {
                    RemovingFromTheList(numbers, numberOrIndex);
                }
                else if (cmdType == "RemoveAt")
                {
                    RemovingAtIndexFromTheList(numbers, numberOrIndex);
                }
                else if (cmdType == "Insert")
                {
                    int indexToInsertAt = int.Parse(cmdArgs[2]);
                    InsertingAtIndexInTheList(numbers, indexToInsertAt, numberOrIndex);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void AddingInTheList(List<int> numbers, int numberToAdd)
        {
            numbers.Add(numberToAdd);
        }

        static void RemovingFromTheList(List<int> numbers, int numberToRemove)
        {
            numbers.Remove(numberToRemove);
        }

        static void RemovingAtIndexFromTheList(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        static void InsertingAtIndexInTheList(List<int> numbers, int index, int number)
        {
            numbers.Insert(index, number);
        }
    }
}

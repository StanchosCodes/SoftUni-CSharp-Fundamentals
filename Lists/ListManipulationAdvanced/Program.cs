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

            string[] cmdArgs = new string[] { };

            int countOfChanges = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                cmdArgs = command.Split();
                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int numberOrIndex = int.Parse(cmdArgs[1]);
                    AddingInTheList(numbers, numberOrIndex);
                    countOfChanges++;
                }
                else if (cmdType == "Remove")
                {
                    int numberOrIndex = int.Parse(cmdArgs[1]);
                    RemovingFromTheList(numbers, numberOrIndex);
                    countOfChanges++;
                }
                else if (cmdType == "RemoveAt")
                {
                    int numberOrIndex = int.Parse(cmdArgs[1]);
                    RemovingAtIndexFromTheList(numbers, numberOrIndex);
                    countOfChanges++;
                }
                else if (cmdType == "Insert")
                {
                    int numberOrIndex = int.Parse(cmdArgs[1]);
                    int indexToInsertAt = int.Parse(cmdArgs[2]);
                    InsertingAtIndexInTheList(numbers, indexToInsertAt, numberOrIndex);
                    countOfChanges++;
                }
                else if (cmdType == "Contains")
                {
                    int numberOrIndex = int.Parse(cmdArgs[1]);
                    if (IsContainingTheNumber(numbers, numberOrIndex))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (cmdType == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", PrintingTheEvenNumbers(numbers)));
                }
                else if (cmdType == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", PrintingTheOddNumbers(numbers)));
                }
                else if (cmdType == "GetSum")
                {
                    Console.WriteLine(GettingTheSumOfAllNumbersOfTheList(numbers));
                }
                else if (cmdType == "Filter")
                {
                    string condition = cmdArgs[1];
                    int numberForTheCondition = int.Parse(cmdArgs[2]);

                    Console.WriteLine(string.Join(" ", FilteringByCondition(numbers, condition, numberForTheCondition)));
                }
            }

            if (countOfChanges != 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

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

        static bool IsContainingTheNumber(List<int> numbers, int number)
        {
            bool containing = false;

                if (numbers.Contains(number))
                {
                    containing = true;
                }
                else
                {
                    containing = false;
                }

            return containing;
        }

        static List<int> PrintingTheEvenNumbers(List<int> numbers)
        {
            List<int> evenList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenList.Add(numbers[i]);
                }
            }

            return evenList;
        }

        static List<int> PrintingTheOddNumbers(List<int> numbers)
        {
            List<int> oddList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddList.Add(numbers[i]);
                }
            }

            return oddList;
        }

        static int GettingTheSumOfAllNumbersOfTheList(List<int> numbers)
        {
            return numbers.Sum();
        }

        static List<int> FilteringByCondition(List<int> numbers, string condition, int number)
        {
            List<int> filteredList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (condition)
                {
                    case "<":
                        if (numbers[i] < number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                        break;
                    case ">":
                        if (numbers[i] > number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                        break;
                    case ">=":
                        if (numbers[i] >= number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                        break;
                    case "<=":
                        if (numbers[i] <= number)
                        {
                            filteredList.Add(numbers[i]);
                        }
                        break;
                }
            }

            return filteredList;
        }
    }
}

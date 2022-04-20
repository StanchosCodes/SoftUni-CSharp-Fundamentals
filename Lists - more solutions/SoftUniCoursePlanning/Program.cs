using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArgs = command.Split(':').ToArray();

                string cmdType = cmdArgs[0];
                string titleOfTheLesson = cmdArgs[1];

                if (cmdType == "Add")
                {
                    if (!schedule.Contains(titleOfTheLesson))
                    {
                        schedule.Add(titleOfTheLesson);
                    }
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);

                    if (!schedule.Contains(titleOfTheLesson))
                    {
                        schedule.Insert(index, titleOfTheLesson);
                    }
                }
                else if (cmdType == "Remove")
                {
                    if (schedule.Contains(titleOfTheLesson))
                    {
                        schedule.Remove(titleOfTheLesson);
                    }

                    if (schedule.Contains(titleOfTheLesson + "-Exercise"))
                    {
                        schedule.Remove(titleOfTheLesson + "-Exercise");
                    }
                }
                else if (cmdType == "Swap")
                {
                    string lessonToSwap = cmdArgs[2];
                    int indexOfFirstLesson = schedule.IndexOf(titleOfTheLesson);
                    int indexOfSecondLesson = schedule.IndexOf(lessonToSwap);

                    if (schedule.Contains(titleOfTheLesson) && schedule.Contains(lessonToSwap))
                    {
                        string firstLesson = titleOfTheLesson;
                        schedule[indexOfFirstLesson] = lessonToSwap;
                        schedule[indexOfSecondLesson] = firstLesson;
                    }

                    if (schedule.Contains(titleOfTheLesson + "-Exercise") && schedule.Contains(titleOfTheLesson))
                    {
                        indexOfFirstLesson = schedule.IndexOf(titleOfTheLesson);
                        schedule.Remove(titleOfTheLesson + "-Exercise");
                        schedule.Insert(indexOfFirstLesson + 1, titleOfTheLesson + "-Exercise");
                    }

                    else if (schedule.Contains(lessonToSwap + "-Exercise") && schedule.Contains(lessonToSwap))
                    {
                        indexOfSecondLesson = schedule.IndexOf(lessonToSwap);
                        schedule.Remove(lessonToSwap + "-Exercise");
                        schedule.Insert(indexOfSecondLesson + 1, lessonToSwap + "-Exercise");
                    }
                }
                else if (cmdType == "Exercise")
                {
                    if (schedule.Contains(titleOfTheLesson) && !schedule.Contains(titleOfTheLesson + "-Exercise"))
                    {
                        int indexOfTheLesson = schedule.IndexOf(titleOfTheLesson);

                        schedule.Insert(indexOfTheLesson + 1, titleOfTheLesson + "-Exercise");
                    }
                    else if (!schedule.Contains(titleOfTheLesson))
                    {
                        schedule.Add(titleOfTheLesson);
                        schedule.Add(titleOfTheLesson + "-Exercise");
                    }
                }
            }

            int indexOfTitles = 1;

            foreach (string curr in schedule)
            {
                Console.WriteLine($"{indexOfTitles}.{curr}");
                indexOfTitles++;
            }
        }
    }
}

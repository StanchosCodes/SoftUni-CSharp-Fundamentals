using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string plannedStops = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newStop = cmdArgs[2];

                    if (index >= 0 && index < plannedStops.Length)
                    {
                        plannedStops = plannedStops.Insert(index, newStop);
                    }
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0 && startIndex < plannedStops.Length && endIndex >= startIndex && endIndex < plannedStops.Length)
                    {
                        plannedStops = plannedStops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                }
                else if (cmdType == "Switch")
                {
                    string stopToReplace = cmdArgs[1];
                    string replacingWord = cmdArgs[2];

                    if (plannedStops.Contains(stopToReplace))
                    {
                        plannedStops = plannedStops.Replace(stopToReplace, replacingWord);
                    }
                }

                Console.WriteLine(plannedStops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {plannedStops}");
        }
    }
}

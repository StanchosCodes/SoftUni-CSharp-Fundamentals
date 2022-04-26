using System;
using System.Collections.Generic;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> participantInfo = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                string currentName = string.Empty;
                int currentDistance = 0;

                foreach (char character in command)
                {
                    if (char.IsLetter(character))
                    {
                        currentName += character;
                    }
                    else if (char.IsDigit(character))
                    {
                        currentDistance += int.Parse(character.ToString());
                    }
                }

                if (participants.Contains(currentName))
                {
                    if (participantInfo.ContainsKey(currentName))
                    {
                        participantInfo[currentName] += currentDistance;
                    }
                    else
                    {
                        participantInfo.Add(currentName, currentDistance);
                    }
                }
            }
                
            int counter = 1;

            foreach (var participant in participantInfo.OrderByDescending(x => x.Value))
            {

                if (counter == 1)
                {    
                Console.WriteLine($"1st place: {participant.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {participant.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {participant.Key}");
                    break;
                }

                counter++;
            }
        }
    }
}

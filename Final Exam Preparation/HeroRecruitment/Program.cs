using System;
using System.Collections.Generic;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> herosSpellBook = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (cmdType == "Enroll")
                {
                    if (!herosSpellBook.ContainsKey(heroName))
                    {
                        herosSpellBook.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }    
                }
                else if (cmdType == "Learn")
                {
                    string spellName = cmdArgs[2];

                    if (herosSpellBook.ContainsKey(heroName))
                    {
                        if (!herosSpellBook[heroName].Contains(spellName))
                        {
                            herosSpellBook[heroName].Add(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                else if (cmdType == "Unlearn")
                {
                    string spellName = cmdArgs[2];

                    if (herosSpellBook.ContainsKey(heroName))
                    {
                        if (herosSpellBook[heroName].Contains(spellName))
                        {
                            herosSpellBook[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in herosSpellBook)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}

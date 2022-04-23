using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyAndId = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string companyName = commandArgs[0];
                string id = commandArgs[1];

                if (!companyAndId.ContainsKey(companyName))
                {
                    companyAndId.Add(companyName, new List<string> { id }); // Добавя нова компания за ключ и ново ID към листа
                }
                else
                {
                    if (!companyAndId[companyName].Contains(id)) // Проверява дали в листа се съдържа даденото ID
                    {
                        companyAndId[companyName].Add(id);
                    }
                }

            }

            foreach (var company in companyAndId)
            {
                Console.WriteLine($"{company.Key}");

                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}

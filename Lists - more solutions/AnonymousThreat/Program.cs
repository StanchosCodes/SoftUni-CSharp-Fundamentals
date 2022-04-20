using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split();

                string cmdType = cmdArgs[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0)
                    {
                        if (endIndex < input.Count)
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                input[startIndex] += input[startIndex + 1];
                                input.RemoveAt(startIndex + 1);
                            }
                        }
                        else if (endIndex < 0 || endIndex >= input.Count)
                        {
                            endIndex = input.Count - 1;

                            for (int i = startIndex; i < endIndex; i++)
                            {
                                input[startIndex] += input[startIndex + 1];
                                input.RemoveAt(startIndex + 1);
                            }
                        }
                    }
                    else if (startIndex < 0 || startIndex >= input.Count)
                    {
                        startIndex = 0;

                        if (endIndex < input.Count)
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                input[startIndex] += input[startIndex + 1];
                                input.RemoveAt(startIndex + 1);
                            }
                        }
                        else if (endIndex < 0 || endIndex >= input.Count)
                        {
                            endIndex = input.Count - 1;

                            for (int i = startIndex; i < endIndex; i++)
                            {
                                input[startIndex] += input[startIndex + 1];
                                input.RemoveAt(startIndex + 1);
                            }
                        }
                    }
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);

                    string currentWord = input[index];

                    if (partitions > currentWord.Length)
                    {
                        return;  // doing nothing if the partitions are more then the length of the current word
                    }

                    int partitionsLength = currentWord.Length / partitions; // 4 / 3 = 1;
                    int partitionsReminder = currentWord.Length % partitions; // 4 % 3 = 1;
                    int lastPartitionLength = partitionsLength + partitionsReminder; // 1 + 1 = 2; {a, b, cd, efgh, ijkl}

                    List<string> partitionsOfTheWord = new List<string>();

                    char[] currentPartition; // that equals null

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            //Last iteration; Last partition; it should be bigger
                            currentPartition = currentWord
                                .Skip(i * partitionsLength)
                                .Take(lastPartitionLength)
                                .ToArray();
                        }
                        else
                        {
                            currentPartition = currentWord
                                .Skip(i * partitionsLength) // пропуска колкото елемента му кажем и му казваме да пропусне елементите от първия до i * partitionsLength защото тях вече сме ги взели и не ни трябват вече
                                .Take(partitionsLength) // взима колкото елемента му кажем след като сме пропуснали тези които не искаме
                                .ToArray();
                        }
                        partitionsOfTheWord.Add(new string(currentPartition)); // currentPartition е масив от чарове, затова му казваме new string и то ги долепя един до друг като създава от това стринг, който пък добавяме в листа
                    }

                    input.RemoveAt(index); // махаме цялата дума на този индекс, която използвахме за да разделим на части
                    input.InsertRange(index, partitionsOfTheWord); // и добаваме вече разделения лист от частите на думата на мястото на цялата дума

                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

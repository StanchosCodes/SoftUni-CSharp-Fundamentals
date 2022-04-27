using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gameBoard = Console.ReadLine()
                .Split()
                .ToList();

            int moves = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                int[] indexes = cmd.Split().Select(int.Parse).ToArray();

                int index1 = indexes[0];
                int index2 = indexes[1];
                moves++;

                if (index1 == index2 || index1 < 0 || index2 < 0 || index1 >= gameBoard.Count || index2 >= gameBoard.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                    gameBoard.Insert(gameBoard.Count / 2, "-" + moves + "a");
                    gameBoard.Insert(gameBoard.Count / 2, "-" + moves + "a");
                    continue;
                }
                else if (gameBoard[index1] == gameBoard[index2])
                {
                    string currentElement = gameBoard[index1];
                    Console.WriteLine($"Congrats! You have found matching elements - {currentElement}!");
                    gameBoard.Remove(currentElement);
                    gameBoard.Remove(currentElement);

                    if (gameBoard.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        break;
                    }
                }
                else if (gameBoard[index1] != gameBoard[index2])
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (gameBoard.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", gameBoard));
            }
        }
    }
}

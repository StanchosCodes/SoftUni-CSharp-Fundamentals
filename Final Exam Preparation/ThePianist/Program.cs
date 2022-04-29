using System;
using System.Collections.Generic;

namespace ThePianist
{
    class Piece
    {
        public Piece(string composer, string key)
        {
            this.Composer = composer;
            this.Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> allPieces = new Dictionary<string, Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieces = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string currPiece = pieces[0];
                string currComposer = pieces[1];
                string currKey = pieces[2];

                if (!allPieces.ContainsKey(currPiece))
                {
                    allPieces.Add(currPiece, new Piece(currComposer, currKey));
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                string pieceName = cmdArgs[1];

                if (cmdType == "Add")
                {
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (!allPieces.ContainsKey(pieceName))
                    {
                        allPieces.Add(pieceName, new Piece(composer, key));
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                }
                else if (cmdType == "Remove")
                {
                    if (allPieces.ContainsKey(pieceName))
                    {
                        allPieces.Remove(pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string newKey = cmdArgs[2];

                    if (allPieces.ContainsKey(pieceName))
                    {
                        allPieces[pieceName].Key = newKey;
                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
            }

            foreach (var piece in allPieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }
}

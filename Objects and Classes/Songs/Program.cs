using System;
using System.Collections.Generic;

namespace Songs
{
    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string TimeOfTheSong { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                string[] inputOfTheSong = Console.ReadLine().Split('_');

                string typeList = inputOfTheSong[0];
                string name = inputOfTheSong[1];
                string timeOfTheSong = inputOfTheSong[2];

                Songs newSong = new Songs();

                newSong.TypeList = typeList;
                newSong.Name = name;
                newSong.TimeOfTheSong = timeOfTheSong;

                songs.Add(newSong);
        }

            string lastCommand = Console.ReadLine();

            if (lastCommand == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Songs> filteredByTypeSongs = songs.FindAll(song => song.TypeList == lastCommand);

                foreach (Songs song in filteredByTypeSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}

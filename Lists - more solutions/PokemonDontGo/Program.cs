using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int currentNum = 0;

            while (pokemonNumbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    currentNum = pokemonNumbers[0];
                    pokemonNumbers[0] = pokemonNumbers.Last();
                }
                else if (index > pokemonNumbers.Count - 1)
                {
                    currentNum = pokemonNumbers.Last();
                    pokemonNumbers[pokemonNumbers.Count - 1] = pokemonNumbers[0];
                }
                else
                {
                    currentNum = pokemonNumbers[index];
                    pokemonNumbers.RemoveAt(index);
                }

                sum += currentNum;

                for (int i = 0; i < pokemonNumbers.Count; i++)
                {
                    if (pokemonNumbers[i] <= currentNum)
                    {
                        pokemonNumbers[i] += currentNum;
                    }
                    else
                    {
                        pokemonNumbers[i] -= currentNum;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}

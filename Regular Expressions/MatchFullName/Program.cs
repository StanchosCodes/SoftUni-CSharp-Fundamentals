using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine(); // четем си входа

            string namePattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b"; // @ - е за ескейпване иначе .Net се бърка дали изпозлваме някакви специални за него символи; \b - казва че трябва всяка дума да започва така както е описано и по този начин не взимаме част от някой стринг, който отговаря на условието, а ще вземем стринга само и единствено ако целия отговаря на условието; [A-Z] - показа че стринга трябва да започва с главна буква от А до Z; [a-z] - показва че стринга трябва да продължи с малки букви от а до z; {1,} - показва че стринга който ще продължи с малки букви от а до z трябва да им 1 или повече символи и ще вземе всичките; това може да се осъществи и с + - плюса показва че ще вземе всички символи които отговарят на усложието, тоест да са малки от а до z

            MatchCollection getName = Regex.Matches(names, namePattern);//взимаме колекция от мачове с име getName с шаблона namepattern

            foreach (Match name in getName) // итерираме всички мачове
            {
                Console.Write($"{name.Value} "); // отпечатваме стойността на всеки мач
            }
        }
    }
}

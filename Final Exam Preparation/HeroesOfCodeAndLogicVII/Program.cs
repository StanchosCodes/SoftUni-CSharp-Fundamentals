using System;
using System.Collections.Generic;

namespace HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public Hero(string name, int health, int mana)
        {
            this.Name = name;
            this.Health = health;
            this.Mana = mana;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string rawHero = Console.ReadLine();

                string[] heroArray = rawHero.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroArray[0];
                int heroHealth = int.Parse(heroArray[1]);
                int heroMana = int.Parse(heroArray[2]);

                heroes.Add(heroName, new Hero(heroName, heroHealth, heroMana));
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArgs[0];
                string nameOfTheHero = cmdArgs[1];

                if (action == "CastSpell")
                {
                    int manaNedded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (heroes[nameOfTheHero].Mana >= manaNedded)
                    {
                        heroes[nameOfTheHero].Mana -= manaNedded;

                        Console.WriteLine($"{nameOfTheHero} has successfully cast {spellName} and now has {heroes[nameOfTheHero].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfTheHero} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    heroes[nameOfTheHero].Health -= damage;

                    if (heroes[nameOfTheHero].Health > 0)
                    {
                        Console.WriteLine($"{nameOfTheHero} was hit for {damage} HP by {attacker} and now has {heroes[nameOfTheHero].Health} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfTheHero} has been killed by {attacker}!");
                        heroes.Remove(nameOfTheHero);
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int currMana = heroes[nameOfTheHero].Mana;
                    heroes[nameOfTheHero].Mana += amount;

                    if (heroes[nameOfTheHero].Mana > 200)
                    {
                        heroes[nameOfTheHero].Mana = 200;
                        Console.WriteLine($"{nameOfTheHero} recharged for {200 - currMana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfTheHero} recharged for {amount} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int currHealth = heroes[nameOfTheHero].Health;

                    heroes[nameOfTheHero].Health += amount;

                    if (heroes[nameOfTheHero].Health > 100)
                    {
                        heroes[nameOfTheHero].Health = 100;
                        Console.WriteLine($"{nameOfTheHero} healed for {100 - currHealth} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfTheHero} healed for {amount} HP!");
                    }
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.Health}");
                Console.WriteLine($"  MP: {hero.Value.Mana}");
            }
        }
    }
}

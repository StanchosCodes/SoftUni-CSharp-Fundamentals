using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Team
    {
        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamArgs = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorName = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);

                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string memberName = joinArgs[0];
                string teamName = joinArgs[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchedTeam.Members.Add(memberName);
            }

            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            PrintValidTeams(teamsWithMembers);
            PrintDisbandedTeams(teamsToDisband);
        }

        static void PrintValidTeams (List<Team> teamsWithMembers)
        {
            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");

                foreach (string currentMember in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currentMember}");
                }
            }
        }

        static void PrintDisbandedTeams(List<Team> teamsToDesband)
        {
            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsToDesband)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}

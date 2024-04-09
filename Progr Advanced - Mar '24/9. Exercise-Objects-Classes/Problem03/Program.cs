namespace Problem03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] userTeamInfo = Console.ReadLine().Split('-');

                string creator = userTeamInfo[0];
                string teamName = userTeamInfo[1];

                bool teamExists = teams.Any(x => x.Name == teamName);

                if(teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                bool userAlreadyCreatedTeam = teams.Any(x => x.Creator == creator);

                if(userAlreadyCreatedTeam)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team
                {
                    Name = teamName,
                    Creator = creator
                };

                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input  = Console.ReadLine();

            while ( input != "end of assignment" )
            {
                string[] memberData = input.Split("->");

                string user = memberData[0];
                string team = memberData[1];

                bool teamExist = teams.Any(x => x.Name == team);

                if (!teamExist)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }

                bool userAlreadyJoinedTeam = teams.Any(x => x.Members.Contains(user) || x.Creator == user);

                if (userAlreadyJoinedTeam)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    input = Console.ReadLine();
                    continue;
                }
                Team currentTeam = teams.FirstOrDefault(x => x.Name == team);
               
                currentTeam.Members.Add(user);

                input = Console.ReadLine();
            }

            var filteredTeams = teams.Where(x => x.Members.Count > 0).
                                         OrderByDescending(x => x.Members.Count).
                                         ThenBy(x => x.Name);

            foreach (Team team in filteredTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach ( var item in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach ( var team in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}



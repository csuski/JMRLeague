using System.Collections.Generic;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class HardCodedMarbleTeamsService : ITeamsService
    {
        List<MarbleTeam> _teams = new List<MarbleTeam> {
            new MarbleTeam { Id = 1, Name = "Balls of Chaos" },
            new MarbleTeam { Id = 2, Name = "Bumblebees" },
            new MarbleTeam { Id = 3, Name = "Crazy Cat's Eyes" },
            new MarbleTeam { Id = 4, Name = "Green Ducks" },
            new MarbleTeam { Id = 5, Name = "Hazers" },
            new MarbleTeam { Id = 6, Name = "Hornets" },
            new MarbleTeam { Id = 7, Name = "Mellow Yellow" },
            new MarbleTeam { Id = 8, Name = "Midnight Wisps" },
            new MarbleTeam { Id = 9, Name = "Minty Maniacs" },
            new MarbleTeam { Id = 10, Name = "O'rangers" },
            new MarbleTeam { Id = 11, Name = "Oceanics" },
            new MarbleTeam { Id = 12, Name = "Raspberry Racers" },
            new MarbleTeam { Id = 13, Name = "Savage Speeders" },
            new MarbleTeam { Id = 14, Name = "Team Galactic" },
            new MarbleTeam { Id = 15, Name = "Team Momo" },
            new MarbleTeam { Id = 16, Name = "Thunderbolts" },
        };

        public Task<MarbleTeams> GetTeams() => Task.FromResult(new MarbleTeams { Teams = _teams });
    }
}
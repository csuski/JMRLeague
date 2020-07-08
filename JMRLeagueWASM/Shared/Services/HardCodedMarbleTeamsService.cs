using System.Collections.Generic;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class HardCodedMarbleTeamsService : IMarbleTeamsService
    {
        List<MarbleTeam> _teams = new List<MarbleTeam> {
            new MarbleTeam { Id = 1, Name = "Balls of Chaos" },
            new MarbleTeam { Id = 2, Name = "Bumblebees" },
            new MarbleTeam { Id = 3, Name = "Crazy Cat's Eyes" },
            new MarbleTeam { Id = 4, Name = "Green Ducks" },
            new MarbleTeam { Id = 5, Name = "Hazers" },
        };

        public Task<MarbleTeams> GetTeams() => Task.FromResult(new MarbleTeams { Teams = _teams });
    }
}
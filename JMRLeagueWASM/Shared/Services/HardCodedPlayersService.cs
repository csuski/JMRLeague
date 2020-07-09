using System.Collections.Generic;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class HardCodedMarblePlayersService : IPlayersService
    {
        List<Player> _players = new List<Player> {
            new Player { Id = 1, Name = "Chris", PlayerName = "Chris" },
            new Player { Id = 2, Name = "Dave", PlayerName = "Dave" },
            new Player { Id = 3, Name = "Jay", PlayerName = "Jay" },
            new Player { Id = 4, Name = "John", PlayerName = "John" },
            new Player { Id = 5, Name = "Tom", PlayerName = "Tom" },
        };

        public Task<Players> GetPlayers() => Task.FromResult(new Players { PlayersList = _players });
    }
}
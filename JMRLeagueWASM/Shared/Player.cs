using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class Player : ITeam
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string PlayerName { get; set; }
    }

    public class Players
    {
        public List<Player> PlayersList { get; set; } = new List<Player>();

        public Player GetPlayer(int id) => PlayersList.SingleOrDefault(player => player.Id == id);
    }
}
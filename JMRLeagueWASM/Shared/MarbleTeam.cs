using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class MarbleTeam : ITeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class MarbleTeams
    {
        public List<MarbleTeam> Teams { get; set; } = new List<MarbleTeam>();

        public MarbleTeam GetTeam(int id) => Teams.SingleOrDefault(team => team.Id == id);
    }
}

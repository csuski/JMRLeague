using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class Standings
    {
        public List<ITeam> Teams { get; set; }

        public List<IEventScores> EventsAndScores { get; set; }

        public int GetTotalPoints(int teamId) => EventsAndScores.Sum(e => e.GetScore(teamId));
    }

    public interface IEventScores
    {
        int Id { get; }
        string Name { get; }
        IDictionary<int, int> Scores { get; }
        int GetScore(int teamId) => Scores[teamId];
    }


    public interface ITeam
    {
        int Id { get; }
        string Name { get; }
    }
}

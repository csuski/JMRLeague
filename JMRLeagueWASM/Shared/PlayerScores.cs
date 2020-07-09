using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class PlayerScores : IEventScores
    {
        public PlayerScores(Players players, Draft draft, MarbleEvent marbleEvent)
        {
            foreach (var p in players.PlayersList)
            {
                var total = 0;
                foreach (var (_, teamId) in draft.DraftedTeams.Where(k => k.playerId == p.Id))
                {
                    total += marbleEvent.Scores[teamId];
                }

                Scores.Add(p.Id, total);
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IDictionary<int, int> Scores { get; } = new Dictionary<int, int>();
    }
}

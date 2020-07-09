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
                foreach (var pick in draft.DraftedTeams.Where(pick => pick.PlayerId == p.Id))
                {
                    total += marbleEvent.Scores[pick.MarbleTeamId];
                }

                Scores.Add(p.Id, total);
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IDictionary<int, int> Scores { get; } = new Dictionary<int, int>();
    }
}

using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class Draft
    {
        public int Id { get; set; }
        public int EventId { get; set; }

        // PlayerId -> TeamId
        public List<Pick> DraftedTeams = new List<Pick>();
    }

    public class Drafts
    {
        public List<Draft> DraftList { get; set; } = new List<Draft>();

        public Draft GetDraft(int id) => DraftList.SingleOrDefault(draft => draft.Id == id);
    }

    public class Pick
    {
        public Pick(int pickNumber, int player, int marbleTeam)
        {
            PickNumber = pickNumber;
            PlayerId = player;
            MarbleTeamId = marbleTeam;
        }

        public int PlayerId { get; }
        public int PickNumber { get; }
        public int MarbleTeamId { get; }
    }
}

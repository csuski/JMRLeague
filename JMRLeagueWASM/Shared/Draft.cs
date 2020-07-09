using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class Draft
    {
        public int Id { get; set; }
        public int EventId { get; set; }

        // PlayerId -> TeamId
        public List<(int playerId, int teamId)> DraftedTeams = new List<(int playerId, int teamId)>();
    }

    public class Drafts
    {
        public List<Draft> DraftList { get; set; } = new List<Draft>();

        public Draft GetDraft(int id) => DraftList.SingleOrDefault(draft => draft.Id == id);
    }
}

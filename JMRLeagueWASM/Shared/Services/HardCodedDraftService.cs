using System.Collections.Generic;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class HardCodedDraftService : IDraftsService
    {
        private List<Draft> _drafts = new List<Draft>()
        {
            new Draft
            {
                Id = 1, EventId = 2,
                DraftedTeams = new List<(int playerId, int teamId)>
                {
                    (1, 1), (2, 2), (3, 3), (4, 4), (5, 5)
                }
            },
            new Draft
            {
                Id = 2, EventId = 3,
                DraftedTeams = new List<(int playerId, int teamId)>
                {
                    (1, 2), (2, 3), (3, 4), (1, 5), (2, 1)
                }
            }

        };


        public Task<Drafts> GetDrafts() => Task.FromResult(new Drafts { DraftList = _drafts });
    }
}

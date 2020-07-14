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
                DraftedTeams = new List<Pick>
                {
                    new Pick(1, 2, 9),
                    new Pick(2, 5, 7),
                    new Pick(3, 1, 12),
                    new Pick(4, 4, 10),
                    new Pick(5, 3, 1),
                    new Pick(6, 3, 2),
                    new Pick(7, 4, 11),
                    new Pick(8, 1, 5),
                    new Pick(9, 5, 3),
                    new Pick(10, 2, 8),
                    new Pick(11, 2, 15),
                    new Pick(12, 5, 4),
                    new Pick(13, 1, 14),
                    new Pick(14, 4, 13),
                    new Pick(15, 3, 16),
                }
            },
            new Draft
            {
                Id = 2, EventId = 3,
                DraftedTeams = new List<Pick>
                {
                    new Pick(1, 5, 3),
                    new Pick(2, 1, 12),
                    new Pick(3, 4, 2),
                    new Pick(4, 3, 1),
                    new Pick(5, 2, 9),
                    new Pick(6, 2, 10),
                    new Pick(7, 3, 16),
                    new Pick(8, 4, 13),
                    new Pick(9, 1, 8),
                    new Pick(10, 5, 7),
                    new Pick(11, 5, 14),
                    new Pick(12, 1, 5),
                    new Pick(13, 4, 11),
                    new Pick(14, 3, 6),
                    new Pick(15, 2, 4),
                }
            },
            new Draft
            {
                Id = 3, EventId = 4,
                DraftedTeams = new List<Pick>
                {
                    new Pick(1, 1, 9),
                    new Pick(2, 4, 10),
                    new Pick(3, 3, 3),
                    new Pick(4, 2, 12),
                    new Pick(5, 5, 1),
                    new Pick(6, 5, 7),
                    new Pick(7, 2, 8),
                    new Pick(8, 3, 5),
                    new Pick(9, 4, 13),
                    new Pick(10, 1, 2),
                    new Pick(11, 1, 11),
                    new Pick(12, 4, 16),
                    new Pick(13, 3, 4),
                    new Pick(14, 2, 15),
                    new Pick(15, 5, 6),
                }
            },
            new Draft
            {
                Id = 4, EventId = 5,
                DraftedTeams = new List<Pick>
                {
                    new Pick(1, 4, 10),
                    new Pick(2, 3, 3),
                    new Pick(3, 2, 9),
                    new Pick(4, 5, 12),
                    new Pick(5, 1, 8),
                    new Pick(6, 1, 14),
                    new Pick(7, 5, 1),
                    new Pick(8, 2, 5),
                    new Pick(9, 3, 2),
                    new Pick(10, 4, 13),
                    new Pick(11, 4, 11),
                    new Pick(12, 3, 4),
                    new Pick(13, 2, 15),
                    new Pick(14, 5, 7),
                    new Pick(15, 1, 6),
                }
            },
        };


        public Task<Drafts> GetDrafts() => Task.FromResult(new Drafts { DraftList = _drafts });
    }
}

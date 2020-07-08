using System;
using System.Collections.Generic;
using System.Linq;

namespace JMRLeague.Shared
{
    public class MarbleEvent : IEventScores
    {
        public int Id { get; set; }

        public int EventNumber { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }

        public IDictionary<int, int> Scores { get; set; } // MarbledID -> Points

        public int GetScore(int teamId) => Scores[teamId];
    }

    public class MarbleEvents
    {
        public List<MarbleEvent> Events { get; set; } = new List<MarbleEvent>();

        public MarbleEvent GetEvent(int id) => Events.SingleOrDefault(marbleEvent => marbleEvent.Id == id);
    }
}

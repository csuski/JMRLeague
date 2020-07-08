using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class HardcodedMarbleEventsService : IMarbleEventsService
    {
        List<MarbleEvent> _events = new List<MarbleEvent> {
           new MarbleEvent {
               Id = 1,
               Date = new DateTime(2020, 6, 21),
               EventNumber = 1,
               Name = "Balancing",
               URL="https://www.youtube.com/watch?v=NPFVLLxhEI4",
               Scores = new Dictionary<int, int> {
                   {1, 12}, {2, 8}, {3, 11}, {4, 7}, {5, 9}
               },
           },
           new MarbleEvent {
               Id = 2,
               Date = new DateTime(2020, 6, 28),
               EventNumber = 1,
               Name = "Halfpipe",
               URL="https://www.youtube.com/watch?v=78zDVL-cYKQ",
               Scores = new Dictionary<int, int> {
                   {1, 3}, {2, 6}, {3, 20}, {4, 4}, {5, 8}
               },
           }
        };


        public Task<MarbleEvents> GetMarbleEvents() => Task.FromResult(new MarbleEvents { Events = _events });
    }
}
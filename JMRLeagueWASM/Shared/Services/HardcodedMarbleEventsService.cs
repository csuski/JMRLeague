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
                   { 1, 12 },
                   { 2, 8 },
                   { 3, 11 },
                   { 4, 7 },
                   { 5, 9 },
                   { 6, 4 },
                   { 7, 0 },
                   { 8, 15 },
                   { 9, 25 },
                   { 10, 6 },
                   { 11, 6 },
                   { 12, 20 },
                   { 13, 2 },
                   { 14, 1 },
                   { 15, 10 },
                   { 16, 3 }
               }
           },
           new MarbleEvent {
               Id = 2,
               Date = new DateTime(2020, 6, 28),
               EventNumber = 2,
               Name = "Halfpipe",
               URL="https://www.youtube.com/watch?v=78zDVL-cYKQ",
               Scores = new Dictionary<int, int> {
                   { 1, 3 },
                   { 2, 6 },
                   { 3, 20 },
                   { 4, 4 },
                   { 5, 8 },
                   { 6, 9 },
                   { 7, 5 },
                   { 8, 12 },
                   { 9, 15 },
                   { 10, 25 },
                   { 11, 0 },
                   { 12, 7 },
                   { 13, 1 },
                   { 14, 11 },
                   { 15, 10 },
                   { 16, 2 }
               },
           },
           new MarbleEvent {
               Id = 3,
               Date = new DateTime(2020, 7, 3),
               EventNumber = 3,
               Name = "Funnel Endurance",
               URL="https://www.youtube.com/watch?v=6CFNNldyI-0",
               Scores = new Dictionary<int, int> {
                   { 1, 11 },
                   { 2, 9 },
                   { 3, 10 },
                   { 4, 12 },
                   { 5, 6 },
                   { 6, 4 },
                   { 7, 1 },
                   { 8, 5 },
                   { 9, 25 },
                   { 10, 20 },
                   { 11, 3 },
                   { 12, 7 },
                   { 13, 15 },
                   { 14, 2 },
                   { 15, 0 },
                   { 16, 8 }
               },
           },
           new MarbleEvent {
               Id = 4,
               Date = new DateTime(2020, 7, 9),
               EventNumber = 4,
               Name = "Newton's Cradle",
               URL="https://www.youtube.com/watch?v=QBdjOa5di1I",
               Scores = new Dictionary<int, int> {
                   { 1, 3 },
                   { 2, 8 },
                   { 3, 12 },
                   { 4, 6 },
                   { 5, 9 },
                   { 6, 1 },
                   { 7, 0 },
                   { 8, 11 },
                   { 9, 10 },
                   { 10, 25 },
                   { 11, 4 },
                   { 12, 15 },
                   { 13, 7 },
                   { 14, 20 },
                   { 15, 5 },
                   { 16, 2 }
               },
           }
        };


        public Task<MarbleEvents> GetMarbleEvents() => Task.FromResult(new MarbleEvents { Events = _events });
    }
}
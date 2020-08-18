using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public interface IMarbleEventsService
    {
        Task<MarbleEvents> GetMarbleEvents();

        Task AddEvent(MarbleEvent marbleEvent);
    }
}
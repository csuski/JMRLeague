using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public interface IPlayersService
    {
        Task<Players> GetPlayers();
    }
}

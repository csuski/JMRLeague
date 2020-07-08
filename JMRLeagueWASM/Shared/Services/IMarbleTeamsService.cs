using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public interface IMarbleTeamsService
    {
        Task<MarbleTeams> GetTeams();
    }
}

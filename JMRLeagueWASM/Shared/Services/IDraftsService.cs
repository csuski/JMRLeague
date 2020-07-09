using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public interface IDraftsService
    {
        Task<Drafts> GetDrafts();
    }
}
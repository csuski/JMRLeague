using Microsoft.Extensions.Options;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class PlayersService : ConfigurableService, IPlayersService
    {

        private const string Route = "/players";

        private readonly HttpClient _httpClient;
        public PlayersService(HttpClient httpClient) => _httpClient = httpClient;

        public PlayersService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            Settings = appSettings.Value;
        }

        public async Task<Players> GetPlayers()
        {
            var route = RoutePrefix + Route;
            Player[] players = await _httpClient.GetFromJsonAsync<Player[]>(route);
            return new Players { PlayersList = players.ToList() };
        }
    }
}

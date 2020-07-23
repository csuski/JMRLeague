using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class MarbleTeamService : ITeamsService
    {
        private const string Route = "/marbleteams";

        private readonly AppSettings _appSettings;
        private readonly HttpClient _httpClient;
        public MarbleTeamService(HttpClient httpClient) => _httpClient = httpClient;

        public MarbleTeamService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<MarbleTeams> GetTeams()
        {
            var route = _appSettings != null ? _appSettings.ServiceUrl + Route : Route;

            MarbleTeam[] teams = await _httpClient.GetFromJsonAsync<MarbleTeam[]>(route);
            return new MarbleTeams { Teams = teams.ToList() };
        }
    }
}

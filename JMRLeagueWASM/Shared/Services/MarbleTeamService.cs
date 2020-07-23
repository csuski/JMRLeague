using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class MarbleTeamService : ITeamsService
    {
        private readonly HttpClient httpClient;
        public MarbleTeamService(HttpClient httpClient) => this.httpClient = httpClient;

        public async Task<MarbleTeams> GetTeams()
        {
            MarbleTeam[] teams = await httpClient.GetFromJsonAsync<MarbleTeam[]>("/marbleteams");
            return new MarbleTeams { Teams = teams.ToList() };
        }
    }
}

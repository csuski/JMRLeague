using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public class MarbleEventService : ConfigurableService, IMarbleEventsService
    {
        private const string Route = "/marbleevents";

        private readonly HttpClient _httpClient;

        public MarbleEventService(HttpClient httpClient) => _httpClient = httpClient;

        public MarbleEventService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            Settings = appSettings.Value;
        }

        public async Task<MarbleEvents> GetMarbleEvents()
        {
            var route = RoutePrefix + Route;
            MarbleEvent[] marbleEvents = await _httpClient.GetFromJsonAsync<MarbleEvent[]>(route);
            return new MarbleEvents { Events = marbleEvents.ToList() };
        }

        public async Task AddEvent(MarbleEvent marbleEvent)
        {
            var route = RoutePrefix + Route;
            await _httpClient.PostAsJsonAsync(route, marbleEvent);
        }
    }
}

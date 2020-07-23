using JMRLeague.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JMRLeagueWASM.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<ITeamsService, MarbleTeamService>();
            builder.Services.AddTransient<IMarbleEventsService, HardcodedMarbleEventsService>();
            builder.Services.AddTransient<IPlayersService, HardCodedMarblePlayersService>();
            builder.Services.AddTransient<IDraftsService, HardCodedDraftService>();
            await builder.Build().RunAsync();
        }
    }
}

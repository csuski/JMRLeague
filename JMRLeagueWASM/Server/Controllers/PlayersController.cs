using JMRLeague.Shared;
using JMRLeagueWASM.Server.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JMRLeagueWASM.Server.Controllers
{
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly MarbleTeamsDBContext db;

        public PlayersController(MarbleTeamsDBContext db) => this.db = db;

        [HttpGet("players")]
        public IQueryable<Player> GetPlayers() => db.Players;
    }
}

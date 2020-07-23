using JMRLeague.Shared;
using JMRLeagueWASM.Server.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JMRLeagueWASM.Server.Controllers
{
    [ApiController]
    public class MarbleTeamController : ControllerBase
    {
        private readonly MarbleTeamsDBContext db;

        public MarbleTeamController(MarbleTeamsDBContext db) => this.db = db;

        [HttpGet("marbleteams")]
        public IQueryable<MarbleTeam> GetMarbleTeams() => db.Teams;
    }
}

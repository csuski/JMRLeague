﻿using System.Threading.Tasks;

namespace JMRLeague.Shared.Services
{
    public interface ITeamsService
    {
        Task<MarbleTeams> GetTeams();
    }
}

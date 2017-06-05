using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core.Abstractions
{
    public interface IMatchesRepository : IRepository<Match>
    {
        Task<List<Match>> GetTournamentCurrentOrFinishedMatches(int tournamentId);

        Task<Match> GetLastMatch();
    }
}

using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core.Abstractions
{
    public interface IPlayersRepository : IRepository<Player>
    {
        Task<List<Player>> GetTournamentPlayers(int tournamentId);
    }
}

using FifaLeague.Core.Abstractions;
using FifaLeague.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Data
{
    class PlayersRepository : RepositoryBase<Player>, IPlayersRepository
    {
        public PlayersRepository(DbContext context) : base(context)
        {
        }

        public async Task<List<Player>> GetTournamentPlayers(int tournamentId)
        {
            var query = GetSet<Tournament>()
                .Where(t => t.Id == tournamentId)
                .SelectMany(t => t.TournamentPlayers)
                .Select(tp => tp.Player);

            return await query.ToListAsync();
        }
    }
}

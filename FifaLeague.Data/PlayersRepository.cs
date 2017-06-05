using FifaLeague.Core.Abstractions;
using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
                .SelectMany(t => t.Players);

            return await query.ToListAsync();
        }
    }
}

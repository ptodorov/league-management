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
    class TournamentsRepository : RepositoryBase<Tournament>, ITournamentsRepository
    {
        public TournamentsRepository(DbContext context) : base(context)
        {
        }

        public async Task<Tournament> GetTournamentById(int tournamentId)
        {
            var query = EntitySet
                .Where(t => t.Id == tournamentId);

            return await query.FirstOrDefaultAsync();
        }
    }
}

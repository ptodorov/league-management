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
    class TournamentsRepository : RepositoryBase<Tournament>, ITournamentsRepository
    {
        public TournamentsRepository(DbContext context) : base(context)
        {
        }

        public async Task<Tournament> GetById(int tournamentId)
        {
            //var query = EntitySet
            //    .Where(t => t.Id == tournamentId);

            //return await query.FirstOrDefaultAsync();

            return new Tournament("Sprint/Summer 2017") { Id = 1 };
        }

        public async Task<Tournament> GetCurrent(DateTime now)
        {
            //var query = EntitySet
            //    .Where(t => t.StartDate <= now && t.EndDate >= now);

            //return await query.FirstOrDefaultAsync();

            return new Tournament("Sprint/Summer 2017") { Id = 1 };
        }
    }
}

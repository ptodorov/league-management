﻿using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifaLeague.Core.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace FifaLeague.Data
{
    class MatchesRepository : RepositoryBase<Match>, IMatchesRepository
    {
        public MatchesRepository(DbContext context) : base(context)
        {
        }

        public async Task<Match> GetById(int matchId)
        {
            var query = EntitySet
                .Where(m => m.Id == matchId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<Match>> GetTournamentCurrentOrFinishedMatches(int tournamentId)
        {
            var query = GetSet<Round>()
                .Where(t => t.TournamentId == tournamentId)
                .SelectMany(t => t.Matches)
                .Where(m => m.State >= MatchState.Playing);

            return await query.ToListAsync();
        }

        public async Task<Match> GetLastMatch()
        {
            //var query = EntitySet
            //    .OrderByDescending(m => m.DatePlayed);

            //return await query.FirstOrDefaultAsync();

            return new Match(1, 2);
        }
    }
}

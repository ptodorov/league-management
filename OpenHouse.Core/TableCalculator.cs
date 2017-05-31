using OpenHouse.Core.Abstractions;
using OpenHouse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Core
{
    public class TableCalculator : ITableCalculator
    {
        private readonly IMatchesRepository _matchesRepository;

        public TableCalculator(IMatchesRepository matchesRepository)
        {
            _matchesRepository = matchesRepository;
        }

        public async Task<Table> GetTournamentTable(int tournamentId)
        {
            var matches = await _matchesRepository.GetTournamentCurrentOrFinishedMatches(tournamentId);

            foreach (Match match in matches)
            {
                
            }
        }
    }
}

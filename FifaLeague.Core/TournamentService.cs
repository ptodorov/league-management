using FifaLeague.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifaLeague.Entities;

namespace FifaLeague.Core
{
    class TournamentService : ITournamentService
    {
        private readonly IMatchesRepository _matchesRepository;

        public TournamentService(IMatchesRepository matchesRepository)
        {
            _matchesRepository = matchesRepository;
        }

        public async Task<string> GetLastGameScreenshot()
        {
            var lastMatch = await _matchesRepository.GetLastMatch();
            return lastMatch?.Screenshot;
        }

        public Task<List<Tournament>> GetAllTournaments()
        {
            throw new NotImplementedException();
        }

        public Task<Tournament> GetCurrentTournament()
        {
            throw new NotImplementedException();
        }

        public Task<Tournament> GetTournamentById(int tournamentId)
        {
            throw new NotImplementedException();
        }
    }
}

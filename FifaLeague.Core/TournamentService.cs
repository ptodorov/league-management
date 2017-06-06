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
        private readonly ITournamentsRepository _tournamentsRepository;
        private readonly IMatchesRepository _matchesRepository;

        public TournamentService(ITournamentsRepository tournamentsRepository, IMatchesRepository matchesRepository)
        {
            _tournamentsRepository = tournamentsRepository;
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

        public async Task<Tournament> GetCurrentTournament()
        {
            DateTime now = DateTime.UtcNow;
            var tournament = await _tournamentsRepository.GetCurrent(now);
            return tournament;
        }

        public async Task<Tournament> GetTournamentById(int tournamentId)
        {
            var tournament = await _tournamentsRepository.GetById(tournamentId);
            return tournament;
        }
    }
}

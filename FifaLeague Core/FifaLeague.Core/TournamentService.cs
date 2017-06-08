using FifaLeague.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifaLeague.Entities;
using System.IO;

namespace FifaLeague.Core
{
    class TournamentService : ITournamentService
    {
        private readonly IFileStorage _fileStorage;
        private readonly ITournamentsRepository _tournamentsRepository;
        private readonly IMatchesRepository _matchesRepository;

        public TournamentService(IFileStorage fileStorage, ITournamentsRepository tournamentsRepository, IMatchesRepository matchesRepository)
        {
            _fileStorage = fileStorage;
            _tournamentsRepository = tournamentsRepository;
            _matchesRepository = matchesRepository;
        }

        public async Task<string> GetLastGameScreenshot()
        {
            string result = null;
            var lastMatch = await _matchesRepository.GetLastMatch();

            if (!string.IsNullOrEmpty(lastMatch?.Screenshot))
            {
                using (var file = await _fileStorage.Read(lastMatch.Screenshot))
                using (BinaryReader br = new BinaryReader(file))
                {
                    byte[] allBytes = br.ReadBytes((int)file.Length);
                    result = "data:image/png;base64," + Convert.ToBase64String(allBytes);
                }
            }

            return result;
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

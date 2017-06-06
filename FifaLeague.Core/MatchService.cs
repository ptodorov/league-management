using FifaLeague.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    class MatchService : IMatchService
    {
        private readonly IMatchesRepository _matchesRepository;
        private readonly IFileStorage _fileStorage;

        public MatchService(IFileStorage fileStorage, IMatchesRepository matchesRepository)
        {
            _fileStorage = fileStorage;
            _matchesRepository = matchesRepository;
        }

        public async Task RegisterMatchResult(int matchId, uint hostGoalsScored, uint guestGoalsScored, Stream screenshot)
        {
            var match = await _matchesRepository.GetById(matchId);

            if (match == null)
            {
                throw new ArgumentException("Match does not exist.");
            }

            if (match.State == Entities.MatchState.Completed)
            {
                throw new InvalidOperationException("Match result has already been registered.");
            }

            string path = await _fileStorage.Write(DateTime.UtcNow.Ticks.ToString(), "image/png", screenshot);

            match.Host.GoalsScored = hostGoalsScored;
            match.Guest.GoalsScored = guestGoalsScored;
            match.Screenshot = path;

            await _matchesRepository.SaveChanges();
        }
    }
}

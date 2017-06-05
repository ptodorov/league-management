using FifaLeague.Core.Abstractions;
using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public class TableCalculator : ITableCalculator
    {
        private readonly IPlayersRepository _playersRepository;
        private readonly IMatchesRepository _matchesRepository;

        public TableCalculator(IPlayersRepository playersRepository, IMatchesRepository matchesRepository)
        {
            _playersRepository = playersRepository;
            _matchesRepository = matchesRepository;
        }

        public async Task<Table> GetTournamentTable(int tournamentId)
        {
            var players = await _playersRepository.GetTournamentPlayers(tournamentId);
            var matches = await _matchesRepository.GetTournamentCurrentOrFinishedMatches(tournamentId);

            List<TableRow> rows = new List<TableRow>();

            foreach (Player player in players)
            {
                TableRowBuilder rowbuilder = new TableRowBuilder(player);

                foreach (Match match in matches)
                {
                    MatchPlayer matchPlayer = null;
                    MatchPlayer matchOpponent = null;

                    if (player.Id == match.Host.PlayerId)
                    {
                        matchPlayer = match.Host;
                        matchOpponent = match.Guest;
                    }
                    else if (player.Id == match.Guest.PlayerId)
                    {
                        matchPlayer = match.Guest;
                        matchOpponent = match.Host;
                    }

                    if (matchPlayer != null)
                    {
                        rowbuilder.AddMatch(matchPlayer.GoalsScored, matchOpponent.GoalsScored);
                    }
                }

                TableRow row = rowbuilder.Build();
                rows.Add(row);
            }

            return new Table(rows);
        }
    }
}

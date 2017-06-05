using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public interface ITournamentService
    {
        Task<string> GetLastGameScreenshot();

        Task<List<Tournament>> GetAllTournaments();

        Task<Tournament> GetCurrentTournament();

        Task<Tournament> GetTournamentById(int tournamentId);
    }
}

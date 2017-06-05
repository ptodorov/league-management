using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public interface ITableCalculator
    {
        Task<Table> GetTournamentTable(int tournamentId);
    }
}

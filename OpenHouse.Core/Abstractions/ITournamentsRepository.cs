using Green4.PrintDesigner.Core.Entities;
using OpenHouse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Core.Abstractions
{
    public interface ITournamentsRepository : IRepository<Tournament>
    {
        Task<Tournament> GetTournamentById(int tournamentId);
    }
}

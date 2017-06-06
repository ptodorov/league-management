using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Core
{
    public interface IMatchService
    {
        Task RegisterMatchResult(int matchId, uint hostGoalsScored, uint guestGoalsScored, Stream screenshot);
    }
}

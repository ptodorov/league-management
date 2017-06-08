using FifaLeague.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifaLeague.Web.Components
{
    public class GoToCurrentTournament : ViewComponent
    {
        private readonly ITournamentService _tournamentService;

        public GoToCurrentTournament(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentTournament = await _tournamentService.GetCurrentTournament();
            return View(currentTournament?.Id);
        }
    }
}

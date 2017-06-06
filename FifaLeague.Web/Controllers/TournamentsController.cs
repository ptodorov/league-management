using FifaLeague.Core;
using FifaLeague.Entities;
using FifaLeague.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FifaLeague.Web.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public TournamentsController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        [Route("tournaments/{id}")]
        public async Task<ActionResult> Index(int id)
        {
            var tournament = await _tournamentService.GetTournamentById(id);
            var viewModel = new TournamentViewModel() { Name = tournament.Name, Announcement = "Still looking like Manchester City are going to keep their first place." };
            return View(viewModel);
        }

        [Route("tournaments/all")]
        public async Task<ActionResult> GetAll()
        {
            var tournaments = await _tournamentService.GetAllTournaments();

            return View();
        }

        [ChildActionOnly]
        public ActionResult GoToCurrentTournament()
        {
            var currentTournament = Task.Run(() => _tournamentService.GetCurrentTournament()).Result;
            return PartialView("_GoToCurrentTournament", currentTournament?.Id);
        }
    }
}
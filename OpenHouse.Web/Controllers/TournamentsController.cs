using OpenHouse.Core;
using OpenHouse.Entities;
using OpenHouse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OpenHouse.Web.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public TournamentsController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        public async Task<ActionResult> Index(int tournamentId)
        {
            var tournament = await _tournamentService.GetTournamentById(tournamentId);
            var viewModel = new TournamentViewModel() { Name = "Spring-Summer 2017", Announcement = "Still looking like Manchester City are going to keep their first place." };
            return View(viewModel);
        }

        [Route("tournaments/all")]
        public async Task<ActionResult> GetAll()
        {
            var tournaments = await _tournamentService.GetAllTournaments();

            return View();
        }
    }
}
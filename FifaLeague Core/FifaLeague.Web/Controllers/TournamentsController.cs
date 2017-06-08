using FifaLeague.Core;
using FifaLeague.Entities;
using FifaLeague.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index(int id)
        {
            var tournament = await _tournamentService.GetTournamentById(id);
            var viewModel = new TournamentViewModel() { Name = tournament.Name, Announcement = "Still looking like Manchester City are going to keep their first place." };
            return View(viewModel);
        }

        [Route("tournaments/all")]
        public async Task<IActionResult> GetAll()
        {
            var tournaments = await _tournamentService.GetAllTournaments();
            return View();
        }
    }
}
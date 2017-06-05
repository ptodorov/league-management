using OpenHouse.Core;
using OpenHouse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OpenHouse.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public HomeController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        public async Task<ActionResult> Index()
        {
            string lastGameScreenshot = await _tournamentService.GetLastGameScreenshot();
            var currentTournament = await _tournamentService.GetCurrentTournament();

            HomeViewModel viewmodel = new HomeViewModel() { CurrentTournamentId = currentTournament.Id, LastGameScreenshot = lastGameScreenshot };
            return View(viewmodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
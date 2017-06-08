using FifaLeague.Core;
using FifaLeague.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FifaLeague.Web.Controllers
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
            HomeViewModel viewmodel = new HomeViewModel() { LastGameResult = "Arsenal 3 : 0 Chelsea", LastGameScreenshot = lastGameScreenshot };
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
using FifaLeague.Core;
using FifaLeague.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FifaLeague.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITournamentService _tournamentService;

        public HomeController(ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        public async Task<IActionResult> Index()
        {
            string lastGameScreenshot = await _tournamentService.GetLastGameScreenshot();
            HomeViewModel viewmodel = new HomeViewModel() { LastGameResult = "Arsenal 3 : 0 Chelsea", LastGameScreenshot = lastGameScreenshot };
            return View(viewmodel);
        }
    }
}
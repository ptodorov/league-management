using FifaLeague.Core;
using FifaLeague.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FifaLeague.Web.Controllers
{
    public class MatchesController : Controller
    {
        private readonly IMatchService _matchService;

        public MatchesController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpPost]
        [Route("match/submit")]
        public async Task<ActionResult> Create(NewMatch newMatch)
        {
            if (ModelState.IsValid && Request.Files.Count > 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    await Request.Files[0].InputStream.CopyToAsync(ms);
                    await _matchService.RegisterMatchResult(newMatch.MatchId, newMatch.HostGoalsScored, newMatch.GuestGoalsScored, ms);
                }

                return RedirectToAction("", "");
            }

            if (Request.Files.Count == 0)
            {
                ModelState.AddModelError("required_screenshot", "Screenshot is required");
            }

            return View(newMatch);
        }
    }
}
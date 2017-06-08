using FifaLeague.Core;
using FifaLeague.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FifaLeague.Web.Controllers
{
    public class MatchesController : Controller
    {
        private readonly IMatchService _matchService;

        public MatchesController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpGet]
        [Route("match/submit")]
        public ActionResult Create()
        {
            List<MatchData> matches = new List<MatchData>();
            matches.Add(new MatchData() { Id = 2, Name = "Arsenal vs Chelsea", RoundName = "10th round" });
            matches.Add(new MatchData() { Id = 2, Name = "Man City vs Liverpool", RoundName = "10th round" });
            matches.Add(new MatchData() { Id = 2, Name = "Man Utd vs Leicester", RoundName = "10th round" });
            matches.Add(new MatchData() { Id = 2, Name = "Tottenham vs Everton", RoundName = "10th round" });

            SubmitMatchViewModel viewModel = new SubmitMatchViewModel()
            {
                Matches = matches
            };

            return View(viewModel);
        }

        [HttpPost]
        [Route("match/submit")]
        public async Task<ActionResult> Create(NewMatch newMatch)
        {
            if (ModelState.IsValid)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    await newMatch.Screenshot.CopyToAsync(ms);
                    ms.Seek(0, SeekOrigin.Begin);
                    await _matchService.RegisterMatchResult(newMatch.MatchId, newMatch.HostGoalsScored, newMatch.GuestGoalsScored, ms);
                }

                return RedirectToAction("", "");
            }

            return View(newMatch);
        }
    }
}
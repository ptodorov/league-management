using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FifaLeague.Web.Models
{
    public class SubmitMatchViewModel
    {
        public List<MatchData> Matches { get; set; }

        public NewMatch Match { get; set; }
    }
}
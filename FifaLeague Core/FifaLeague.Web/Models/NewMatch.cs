using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FifaLeague.Web.Models
{
    public class NewMatch
    {
        public int MatchId { get; set; }

        public uint HostGoalsScored { get; set; }

        public uint GuestGoalsScored { get; set; }

        public IFormFile Screenshot { get; set; }
    }
}
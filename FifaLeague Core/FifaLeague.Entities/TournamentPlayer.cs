using System;
using System.Collections.Generic;
using System.Text;

namespace FifaLeague.Entities
{
    public class TournamentPlayer
    {
        public int TournamentId { get; set; }

        public int PlayerId { get; set; }

        public virtual Tournament Tournament { get; set; }

        public virtual Player Player { get; set; }
    }
}

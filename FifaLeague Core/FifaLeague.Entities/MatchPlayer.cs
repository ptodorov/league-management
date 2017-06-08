using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Entities
{
    public class MatchPlayer
    {
        protected MatchPlayer()
        { }

        internal MatchPlayer(int playerId, MatchRole matchRole) : this()
        {
            PlayerId = playerId;
            MatchRole = matchRole;
        }

        public int MatchId { get; set; }

        public int PlayerId { get; protected set; }

        public MatchRole MatchRole { get; protected set; }

        public uint GoalsScored { get; set; }

        public virtual Match Match { get; set; }
    }
}

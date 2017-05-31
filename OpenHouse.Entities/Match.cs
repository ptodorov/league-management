﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Entities
{
    public class Match
    {
        protected Match()
        {
            Players = new HashSet<MatchPlayer>();
        }

        public Match(int hostPlayerId, int guestPlayerId) : this()
        {
            Players.Add(new MatchPlayer(hostPlayerId, MatchRole.Host));
            Players.Add(new MatchPlayer(guestPlayerId, MatchRole.Guest));
        }

        public int Id { get; set; }

        public MatchState State { get; protected set; }

        public int RoundId { get; protected set; }

        public virtual Round Round { get; protected set; }

        protected virtual ICollection<MatchPlayer> Players { get; set; }

        public MatchPlayer Host
        {
            get { return Players.Single(p => p.MatchRole == MatchRole.Host); }
        }

        public MatchPlayer Guest
        {
            get { return Players.Single(p => p.MatchRole == MatchRole.Guest); }
        }
    }
}

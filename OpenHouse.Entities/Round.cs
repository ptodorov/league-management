﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Entities
{
    public class Round
    {
        protected Round()
        { }

        public int Id { get; protected set; }

        public int TournamentId { get; protected set; }

        public int Number { get; protected set; }

        public Tournament Tournament { get; protected set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Core
{
    public class TableRow
    {
        internal TableRow()
        { }

        public uint Position { get; protected set; }

        public string PlayerName { get; protected set; }

        public string TeamName { get; protected set; }

        public uint Wins { get; protected set; }

        public uint Draws { get; protected set; }

        public uint Losses { get; protected set; }

        public uint GoalsScored { get; protected set; }

        public uint GoalsConceded { get; protected set; }

        public int GoalDifference
        {
            get { return (int)GoalsScored - (int)GoalsConceded; }
        }

        public uint Points
        {
            get { return Wins * 3 + Draws; }
        }
    }
}

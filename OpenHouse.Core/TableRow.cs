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

        public uint Position { get; internal set; }

        public string PlayerName { get; internal set; }

        public string TeamName { get; internal set; }

        public uint Wins { get; internal set; }

        public uint Draws { get; internal set; }

        public uint Losses { get; internal set; }

        public uint GoalsScored { get; internal set; }

        public uint GoalsConceded { get; internal set; }

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

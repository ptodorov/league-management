using OpenHouse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Core
{
    class TableRowBuilder
    {
        private readonly Player _player;
        private uint _wins;
        private uint _draws;
        private uint _losses;

        public TableRowBuilder(Player player)
        {
            _player = player;
        }

        public uint GoalsScored { get; private set; }

        public uint GoalsConceded { get; private set; }

        public void AddMatch(uint goalsScored, uint goalsConceded)
        {
            if (goalsScored > goalsConceded)
            {
                _wins++;
            }
            else if (goalsScored < goalsConceded)
            {
                _losses++;
            }
            else
            {
                _draws++;
            }

            GoalsScored += goalsScored;
            GoalsConceded += goalsConceded;
        }

        public TableRow Build()
        {
            return new TableRow()
            {
                PlayerName = _player.Name,
                TeamName = _player.TeamName,
                Wins = _wins,
                Draws = _draws,
                Losses = _losses,
                GoalsScored = GoalsScored,
                GoalsConceded = GoalsScored
            };
        }
    }
}

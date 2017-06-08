using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Entities
{
    public class Tournament
    {
        protected Tournament()
        {
            TournamentPlayers = new HashSet<TournamentPlayer>();
        }

        public Tournament(string name) : this()
        {
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; protected set; }

        public DateTime StartDate { get; protected set; }

        public DateTime EndDate { get; protected set; }

        public ICollection<TournamentPlayer> TournamentPlayers { get; protected set; }
    }
}

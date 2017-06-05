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
            Players = new HashSet<Player>();
        }

        public Tournament(string name) : this()
        {
            Name = name;
        }

        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public ICollection<Player> Players { get; protected set; }
    }
}

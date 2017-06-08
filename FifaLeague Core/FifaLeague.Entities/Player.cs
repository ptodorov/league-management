using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Entities
{
    public class Player
    {
        protected Player()
        { }

        public Player(string name) : this()
        {
            Name = name;
        }

        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public string TeamName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Entities
{
    public class Tournament
    {
        protected Tournament()
        { }

        public Tournament(string name) : this()
        {
            Name = name;
        }

        public int Id { get; protected set; }

        public string Name { get; protected set; }
    }
}

using OpenHouse.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse.Data
{
    public class FifaLeagueContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Round>()
                .HasRequired(r => r.Tournament)
                .WithMany();


        }
    }
}

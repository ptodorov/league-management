using FifaLeague.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Data
{
    public class FifaLeagueContext : DbContext
    {
        public FifaLeagueContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>()
                .HasMany(t => t.Players)
                .WithMany();

            modelBuilder.Entity<Round>()
                .HasRequired(r => r.Tournament)
                .WithMany();

            modelBuilder.Entity<Round>()
                .HasMany(r => r.Matches)
                .WithRequired(m => m.Round);
        }
    }
}

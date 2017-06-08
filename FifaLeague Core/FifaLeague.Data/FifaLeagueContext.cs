using FifaLeague.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaLeague.Data
{
    public class FifaLeagueContext : DbContext
    {
        public FifaLeagueContext(DbContextOptions<FifaLeagueContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TournamentPlayer>()
                .HasKey(tp => new { tp.TournamentId, tp.PlayerId });

            modelBuilder.Entity<TournamentPlayer>()
                .HasOne(tp => tp.Tournament)
                .WithMany(t => t.TournamentPlayers);

            modelBuilder.Entity<TournamentPlayer>()
                .HasOne(tp => tp.Player)
                .WithMany();

            modelBuilder.Entity<Round>()
                .HasOne(r => r.Tournament)
                .WithMany();

            modelBuilder.Entity<Round>()
                .HasMany(r => r.Matches)
                .WithOne(m => m.Round);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TournamentManagement.Models.Domains;

namespace TournamentManagement
{
    public class Context : DbContext
    {
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Match>()
                .HasKey(x => new { x.AwayParticipantId, x.HomeParticipantId });

            modelBuilder.Entity<Match>()
                .HasOne(m => m.HomeParticipant)
                .WithMany(p => p.MatchesAsHost)
                .HasForeignKey(m => m.HomeParticipantId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.AwayParticipant)
                .WithMany(p => p.MatchesAsGuest)
                .HasForeignKey(m => m.AwayParticipantId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Participant>()
            //    .HasOne(p => p.Team)
            //    .WithMany(t => t.Participants)
            //    .HasForeignKey(p => p.TeamId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

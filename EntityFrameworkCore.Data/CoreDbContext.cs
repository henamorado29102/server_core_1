using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Domain;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
    public class CoreDbContext : DbContext
    {

        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=core_1;User Id=sa;Password=MyPass@word;TrustServerCertificate=True")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
            .HasOne(m => m.AwayTeam)
            .WithMany(t => t.MatchAwayTeams)
            .HasForeignKey(m => m.AwayTeamId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.HomeTeam)
                .WithMany(t => t.MatchHomeTeams)
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>(entity =>
    {
        entity.Property(e => e.TicketPrice)
            .HasPrecision(18, 2);
    });

            modelBuilder.Entity<Team>()
                .HasOne(t => t.League)
                .WithMany(l => l.Teams)
                .HasForeignKey(t => t.LeagueId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);


            // Seeding a League
            modelBuilder.Entity<League>().HasData(
                new League
                {
                    Id = 1,
                    Name = "Premier League",
                    CreatedBy = "System",
                    CreatedDate = DateTime.UtcNow,
                    ModifiedBy = "System",
                    ModifiedDate = DateTime.UtcNow
                });

            // Seeding Teams
            var teams = new Team[10];
            for (int i = 1; i <= 10; i++)
            {
                teams[i - 1] = new Team
                {
                    Id = i,
                    Name = $"Team {i}",
                    LeagueId = 1,
                    CreatedBy = "System",
                    ModifiedBy = "System",
                    ModifiedDate = DateTime.UtcNow
                };
            }
            modelBuilder.Entity<Team>().HasData(teams);

            // Seeding Coaches
            var coaches = new Coach[10];
            for (int i = 1; i <= 10; i++)
            {
                coaches[i - 1] = new Coach
                {
                    Id = i,
                    Name = $"Coach {i}",
                    TeamId = i,
                    CreatedBy = "System",
                    ModifiedBy = "System",
                    ModifiedDate = DateTime.UtcNow
                };
            }
            modelBuilder.Entity<Coach>().HasData(coaches);

            // Seeding Matches
            var matches = new Match[45]; // 10 teams, each playing each other once
            int matchId = 1;
            for (int home = 1; home <= 10; home++)
            {
                for (int away = home + 1; away <= 10; away++)
                {
                    matches[matchId - 1] = new Match
                    {
                        Id = matchId,
                        HomeTeamId = home,
                        AwayTeamId = away,
                        Date = DateTime.UtcNow.AddDays(matchId), // Example dates
                        CreatedBy = "System",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedBy = "System",
                        ModifiedDate = DateTime.UtcNow,
                        TicketPrice = 50m
                    };
                    matchId++;
                }
            }
            modelBuilder.Entity<Match>().HasData(matches);

        }
    }
}
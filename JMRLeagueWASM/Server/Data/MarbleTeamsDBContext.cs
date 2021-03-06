﻿using JMRLeague.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JMRLeagueWASM.Server.Data
{
    public class MarbleTeamsDBContext : DbContext
    {
        public MarbleTeamsDBContext(DbContextOptions<MarbleTeamsDBContext> options) :
            base(options)
        { }

        public DbSet<MarbleTeam> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MarbleTeamConfiguration());
            modelBuilder.ApplyConfiguration(new PlayersConfiguration());
            
        }
    }

    public class PlayersConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(player => player.Id);
            builder.HasData(
                new Player { Id = 1, Name = "Chris", PlayerName = "Chris" },
                new Player { Id = 2, Name = "Dave", PlayerName = "Dave" },
                new Player { Id = 3, Name = "Jay", PlayerName = "Jay" },
                new Player { Id = 4, Name = "John", PlayerName = "John" },
                new Player { Id = 5, Name = "Tom", PlayerName = "Tom" }
            );
        }
    }

    public class MarbleTeamConfiguration : IEntityTypeConfiguration<MarbleTeam>
    {
        public void Configure(EntityTypeBuilder<MarbleTeam> builder)
        {
            builder.HasKey(team => team.Id);
            builder.HasData(
                new MarbleTeam { Id = 1, Name = "Balls of Chaos" },
                new MarbleTeam { Id = 2, Name = "Bumblebees" },
                new MarbleTeam { Id = 3, Name = "Crazy Cat's Eyes" },
                new MarbleTeam { Id = 4, Name = "Green Ducks" },
                new MarbleTeam { Id = 5, Name = "Hazers" },
                new MarbleTeam { Id = 6, Name = "Hornets" },
                new MarbleTeam { Id = 7, Name = "Mellow Yellow" },
                new MarbleTeam { Id = 8, Name = "Midnight Wisps" },
                new MarbleTeam { Id = 9, Name = "Minty Maniacs" },
                new MarbleTeam { Id = 10, Name = "O'rangers" },
                new MarbleTeam { Id = 11, Name = "Oceanics" },
                new MarbleTeam { Id = 12, Name = "Raspberry Racers" },
                new MarbleTeam { Id = 13, Name = "Savage Speeders" },
                new MarbleTeam { Id = 14, Name = "Team Galactic" },
                new MarbleTeam { Id = 15, Name = "Team Momo" },
                new MarbleTeam { Id = 16, Name = "Thunderbolts" }
            );
        }
    }
}

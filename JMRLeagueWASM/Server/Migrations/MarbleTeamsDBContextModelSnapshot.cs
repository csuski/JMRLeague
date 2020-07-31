﻿// <auto-generated />
using JMRLeagueWASM.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JMRLeagueWASM.Server.Migrations
{
    [DbContext(typeof(MarbleTeamsDBContext))]
    partial class MarbleTeamsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("JMRLeague.Shared.MarbleTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Balls of Chaos"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bumblebees"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Crazy Cat's Eyes"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Green Ducks"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hazers"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hornets"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mellow Yellow"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Midnight Wisps"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Minty Maniacs"
                        },
                        new
                        {
                            Id = 10,
                            Name = "O'rangers"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Oceanics"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Raspberry Racers"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Savage Speeders"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Team Galactic"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Team Momo"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Thunderbolts"
                        });
                });

            modelBuilder.Entity("JMRLeague.Shared.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayerName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chris",
                            PlayerName = "Chris"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dave",
                            PlayerName = "Dave"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jay",
                            PlayerName = "Jay"
                        },
                        new
                        {
                            Id = 4,
                            Name = "John",
                            PlayerName = "John"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tom",
                            PlayerName = "Tom"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

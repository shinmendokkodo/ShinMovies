using Microsoft.EntityFrameworkCore;
using Shin.Movies.Configuration.Seeding;
using ShinMovies.Models.Entities;
using System;
using System.Reflection;

namespace EFCoreMovies.Context;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
        configurationBuilder.Properties<string>().HaveMaxLength(150);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Seed();
    }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<CinemaOffer> CinemaOffers { get; set; }
    public DbSet<CinemaHall> CinemaHalls { get; set; }
    public DbSet<MovieActor> MovieActors { get; set; }
}

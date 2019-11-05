using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MediaCollection.Database;

namespace MediaCollection.Data
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    Title = "The Shawshank Redemption",
                    Genre = "Drama",
                    Duration = new TimeSpan(0, 2, 22, 0),
                    ReleaseDate = new DateTime(1995, 3, 2),
                    Synopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Director = "Frank Darabont",
                    Cast = "Tim Robbins, Morgan Freeman, Bob Gunton"
                });


            modelBuilder.Entity<Serie>().HasData(
                new Serie
                {
                    SerieID = 1,
                    Title = "Game of Thrones",
                    Genre = "Action, Adventure, Drama",
                    Director = "D.B. Weiss, David Benioff",
                    Cast = "Emilia Clarke, Peter Dinklage, Kit Harrington, Maisie Williams",
                    ReleaseDate = new DateTime(2011)                    
                });


            modelBuilder.Entity<Episode>().HasData(
                new Episode
                {
                    EpisodeID = 1,
                    Season = 1,
                    EpisodeNo = 1,
                    Duration = new TimeSpan(0, 1, 2, 0),
                    Synopsis = "Eddard Stark is torn between his family and an old friend when asked to serve at the side of King Robert Baratheon; Viserys plans to wed his sister to a nomadic warlord in exchange for an army.",
                    //SerieID = 1
                });


            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumID = 1,
                    Title = "Dark Side of the Moon",
                    Genre = "Experimental Rock",
                    AlbumArtist = "Pink Floyd",
                    ReleaseDate = new DateTime(1973),
                    Duration = new TimeSpan(0, 0, 48, 0)
                });


            modelBuilder.Entity<Track>().HasData(
                new Track
                {
                    TrackID = 1,
                    TrackNo = 1,
                    TrackName = "Speak to Me",
                    Artist = "Pink Floyd",
                    Duration = new TimeSpan(0,0,1,30),
                    //AlbumID = 1
                });


            modelBuilder.Entity<Podcast>().HasData(
                new Podcast
                {
                    PodcastID = 1,
                    Publisher = "Begijn Le Blue",
                    Title = "Fwiet! Fwiet!",
                });


            modelBuilder.Entity<PodcastEpisode>().HasData(
                new PodcastEpisode
                {
                    PodcastEpisodeID = 1,
                    EpisodeNo = 1,
                    Title = "De Specht",
                    Duration = new TimeSpan(0,0,12,45),
                    //PodcastID = 1
                });
        }
    }
}

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
                new
                {
                    MovieID = 1,
                    Title = "The Shawshank Redemption",
                    Genre = "Drama",
                    Duration = new TimeSpan(0, 2, 22, 0),
                    ReleaseDate = new DateTime(1995, 3, 2),
                    Synopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Director = "Frank Darabont",
                    Cast = "Tim Robbins, Morgan Freeman, Bob Gunton",
                    MovieRatingID = 1,
                    MovieReviewID = 1
                });

            modelBuilder.Entity<MovieRating>().HasData(
                new
                {
                    MovieRatingID = 1,
                    Rating = 9,
                    User = "cage2005@hotmail.com"                   
                });

            modelBuilder.Entity<MovieReview>().HasData(
                new
                {
                    MovieReviewID = 1,
                    Review = "Can Hollywood, usually creating things for entertainment purposes only, create art? To create something of this nature, a director must approach it in a most meticulous manner, due to the delicacy of the process. Such a daunting task requires an extremely capable artist with an undeniable managerial capacity and an acutely developed awareness of each element of art in their films, the most prominent; music, visuals, script, and acting. These elements, each equally important, must succeed independently, yet still form a harmonious union, because this mixture determines the fate of the artist's opus. Though already well known amongst his colleagues for his notable skills at writing and directing, Frank Darabont emerges with his feature film directorial debut, The Shawshank Redemption. Proving himself already a master of the craft, Darabont managed to create one of the most recognizable independent releases in the history of Hollywood. The Shawshank Redemption defines a genre, defies the odds, compels the emotions, and brings an era of artistically influential films back to Hollywood.",
                    User = "cage2005@hotmail.com"
                });


            modelBuilder.Entity<Serie>().HasData(
                new
                {
                    SerieID = 1,
                    Title = "Game of Thrones",
                    Genre = "Action, Adventure, Drama",
                    Director = "D.B. Weiss, David Benioff",
                    Cast = "Emilia Clarke, Peter Dinklage, Kit Harrington",
                    ReleaseDate = new DateTime(2011,4,17),
                    EpisodeID = 1,
                    SerieRatingID = 1,
                    SerieReviewID = 1
                });

            modelBuilder.Entity<Episode>().HasData(
                new
                {
                    EpisodeID = 1,
                    Season = 1,
                    EpisodeNo = 1,
                    Duration = new TimeSpan(0, 1, 2, 0),
                    Synopsis = "Eddard Stark is torn between his family and an old friend when asked to serve at the side of King Robert Baratheon; Viserys plans to wed his sister to a nomadic warlord in exchange for an army.",                   
                });

            modelBuilder.Entity<SerieRating>().HasData(
                new
                {
                    SerieRatingID = 1,
                    Rating = 9,
                    User = "cage2005@hotmail.com"
                });

            modelBuilder.Entity<SerieReview>().HasData(
                new
                {
                    SerieReviewID = 1,
                    Review = "It was a master piece. It was written to the perfection. It was mesmerizing. It was gripping. It was so shocking that if someone is binge watching this show he/she will need a time-off in between to get their head around things and accept some messed up, yet mind blowing development. But yet, I cant hate it enough after final season.Its like you came to know that you were in love with the wrong one all along.It was like looking at a completely different person.It was like seeing your own dreams and expectations get destroyed.It was not a let down, it was a BETRAYAL!",
                    User = "cage2005@hotmail.com"
                });


            modelBuilder.Entity<Album>().HasData(
                new
                {
                    AlbumID = 1,
                    Title = "Dark Side of the Moon",
                    Genre = "Experimental Rock",
                    AlbumArtist = "Pink Floyd",
                    ReleaseDate = new DateTime(1973),
                    Duration = new TimeSpan(0, 0, 48, 0),
                    TrackID = 1
                });


            modelBuilder.Entity<Track>().HasData(
                new
                {
                    TrackID = 1,
                    TrackNo = 1,
                    TrackName = "Speak to Me",
                    Artist = "Pink Floyd",
                    Duration = new TimeSpan(0,0,1,30)                  
                });


            modelBuilder.Entity<Podcast>().HasData(
                new
                {
                    PodcastID = 1,
                    Publisher = "Begijn Le Blue",
                    Title = "Fwiet! Fwiet!",  
                    PodcastEpisodeID = 1
                });


            modelBuilder.Entity<PodcastEpisode>().HasData(
                new
                {
                    PodcastEpisodeID = 1,
                    EpisodeNo = 1,
                    Title = "De Specht",
                    Duration = new TimeSpan(0,0,12,45),
                    Date = new DateTime(2019,1,1),
                    Hosts = "",
                    Guests = ""
                });
        }
    }
}

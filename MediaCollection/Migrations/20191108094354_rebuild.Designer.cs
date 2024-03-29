﻿// <auto-generated />
using System;
using MediaCollection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediaCollection.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191108094354_rebuild")]
    partial class rebuild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaCollection.Database.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumArtist")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Cover")
                        .HasColumnType("varbinary(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("AlbumID");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumID = 1,
                            AlbumArtist = "Pink Floyd",
                            Duration = new TimeSpan(0, 0, 48, 0, 0),
                            Genre = "Experimental Rock",
                            ReleaseDate = new DateTime(1973, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "The Dark Side of the Moon is the eighth studio album by English rock band Pink Floyd, released on 1 March 1973 by Harvest Records.Primarily developed during live performances, the band premiered an early version of the record several months before recording began.New material was recorded in two sessions in 1972 and 1973 at Abbey Road Studios in London.",
                            Title = "Dark Side of the Moon"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.AlbumRating", b =>
                {
                    b.Property<int>("AlbumRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumRatingID");

                    b.HasIndex("AlbumID");

                    b.ToTable("AlbumRatings");

                    b.HasData(
                        new
                        {
                            AlbumRatingID = 1,
                            AlbumID = 1,
                            Rating = 9,
                            User = "Cage2005@hotmail.com"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.AlbumReview", b =>
                {
                    b.Property<int>("AlbumReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumID")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumReviewID");

                    b.HasIndex("AlbumID");

                    b.ToTable("AlbumReviews");
                });

            modelBuilder.Entity("MediaCollection.Database.Episode", b =>
                {
                    b.Property<int>("EpisodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("EpisodeNo")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<int?>("SerieID")
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.HasKey("EpisodeID");

                    b.HasIndex("SerieID");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeID = 1,
                            Duration = new TimeSpan(0, 1, 2, 0, 0),
                            EpisodeNo = 1,
                            Season = 1,
                            SerieID = 1,
                            Synopsis = "Eddard Stark is torn between his family and an old friend when asked to serve at the side of King Robert Baratheon; Viserys plans to wed his sister to a nomadic warlord in exchange for an army."
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Poster")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MovieID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Cast = "Tim Robbins, Morgan Freeman, Bob Gunton",
                            Director = "Frank Darabont",
                            Duration = new TimeSpan(0, 2, 22, 0, 0),
                            Genre = "Drama",
                            ReleaseDate = new DateTime(1995, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Title = "The Shawshank Redemption"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.MovieRating", b =>
                {
                    b.Property<int>("MovieRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieRatingID");

                    b.HasIndex("MovieID");

                    b.ToTable("MovieRatings");

                    b.HasData(
                        new
                        {
                            MovieRatingID = 1,
                            MovieID = 1,
                            Rating = 9,
                            User = "cage2005@hotmail.com"
                        },
                        new
                        {
                            MovieRatingID = 2,
                            MovieID = 1,
                            Rating = 8,
                            User = "gerben.calus@vdab.be"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.MovieReview", b =>
                {
                    b.Property<int>("MovieReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieReviewID");

                    b.HasIndex("MovieID");

                    b.ToTable("MovieReviews");

                    b.HasData(
                        new
                        {
                            MovieReviewID = 1,
                            MovieID = 1,
                            Review = "Can Hollywood, usually creating things for entertainment purposes only, create art? To create something of this nature, a director must approach it in a most meticulous manner, due to the delicacy of the process. Such a daunting task requires an extremely capable artist with an undeniable managerial capacity and an acutely developed awareness of each element of art in their films, the most prominent; music, visuals, script, and acting. These elements, each equally important, must succeed independently, yet still form a harmonious union, because this mixture determines the fate of the artist's opus. Though already well known amongst his colleagues for his notable skills at writing and directing, Frank Darabont emerges with his feature film directorial debut, The Shawshank Redemption. Proving himself already a master of the craft, Darabont managed to create one of the most recognizable independent releases in the history of Hollywood. The Shawshank Redemption defines a genre, defies the odds, compels the emotions, and brings an era of artistically influential films back to Hollywood.",
                            User = "cage2005@hotmail.com"
                        },
                        new
                        {
                            MovieReviewID = 2,
                            MovieID = 1,
                            Review = "Why do I want to write the 234th comment on The Shawshank Redemption? I am not sure - almost everything that could be possibly said about it has been said. But like so many other people who wrote comments, I was and am profoundly moved by this simple and eloquent depiction of hope and friendship and redemption.",
                            User = "gerben.calus@vdab.be"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.Podcast", b =>
                {
                    b.Property<int>("PodcastID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Poster")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("PodcastID");

                    b.ToTable("Podcasts");

                    b.HasData(
                        new
                        {
                            PodcastID = 1,
                            Publisher = "Begijn Le Blue",
                            Synopsis = "Every week 3 new birds are discussed with professional bird-watchers.",
                            Title = "Fwiet! Fwiet!"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.PodcastEpisode", b =>
                {
                    b.Property<int>("PodcastEpisodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("EpisodeNo")
                        .HasColumnType("int");

                    b.Property<string>("Guests")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Hosts")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("PodcastID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("PodcastEpisodeID");

                    b.HasIndex("PodcastID");

                    b.ToTable("PodcastEpisodes");

                    b.HasData(
                        new
                        {
                            PodcastEpisodeID = 1,
                            Date = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = new TimeSpan(0, 0, 12, 45, 0),
                            EpisodeNo = 1,
                            Guests = "",
                            Hosts = "",
                            PodcastID = 1,
                            Title = "De Specht"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.PodcastRating", b =>
                {
                    b.Property<int>("PodcastRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PodcastID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("PodcastRatingID");

                    b.HasIndex("PodcastID");

                    b.ToTable("PodcastRatings");
                });

            modelBuilder.Entity("MediaCollection.Database.PodcastReview", b =>
                {
                    b.Property<int>("PodcastReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PodcastID")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PodcastReviewID");

                    b.HasIndex("PodcastID");

                    b.ToTable("PodcastReviews");
                });

            modelBuilder.Entity("MediaCollection.Database.Serie", b =>
                {
                    b.Property<int>("SerieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Poster")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("SerieID");

                    b.ToTable("Series");

                    b.HasData(
                        new
                        {
                            SerieID = 1,
                            Cast = "Emilia Clarke, Peter Dinklage, Kit Harrington",
                            Director = "D.B. Weiss, David Benioff",
                            Genre = "Action, Adventure, Drama",
                            ReleaseDate = new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Synopsis = "Nine noble families fight for control over the mythical lands of Westeros, while an ancient enemy returns after being dormant for thousands of years.",
                            Title = "Game of Thrones"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.SerieRating", b =>
                {
                    b.Property<int>("SerieRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("SerieID")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SerieRatingID");

                    b.HasIndex("SerieID");

                    b.ToTable("SerieRatings");

                    b.HasData(
                        new
                        {
                            SerieRatingID = 1,
                            Rating = 9,
                            SerieID = 1,
                            User = "cage2005@hotmail.com"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.SerieReview", b =>
                {
                    b.Property<int>("SerieReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<int?>("SerieID")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SerieReviewID");

                    b.HasIndex("SerieID");

                    b.ToTable("SerieReviews");

                    b.HasData(
                        new
                        {
                            SerieReviewID = 1,
                            Review = "It was a master piece. It was written to the perfection. It was mesmerizing. It was gripping. It was so shocking that if someone is binge watching this show he/she will need a time-off in between to get their head around things and accept some messed up, yet mind blowing development. But yet, I cant hate it enough after final season.Its like you came to know that you were in love with the wrong one all along.It was like looking at a completely different person.It was like seeing your own dreams and expectations get destroyed.It was not a let down, it was a BETRAYAL!",
                            SerieID = 1,
                            User = "cage2005@hotmail.com"
                        });
                });

            modelBuilder.Entity("MediaCollection.Database.Track", b =>
                {
                    b.Property<int>("TrackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumID")
                        .HasColumnType("int");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("TrackName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TrackNo")
                        .HasColumnType("int");

                    b.HasKey("TrackID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            TrackID = 1,
                            AlbumID = 1,
                            Artist = "Pink Floyd",
                            Duration = new TimeSpan(0, 0, 1, 30, 0),
                            TrackName = "Speak to Me",
                            TrackNo = 1
                        },
                        new
                        {
                            TrackID = 2,
                            AlbumID = 1,
                            Artist = "Pink Floyd",
                            Duration = new TimeSpan(0, 0, 2, 43, 0),
                            TrackName = "Breathe",
                            TrackNo = 2
                        },
                        new
                        {
                            TrackID = 3,
                            AlbumID = 1,
                            Artist = "Pink Floyd",
                            Duration = new TimeSpan(0, 0, 3, 36, 0),
                            TrackName = "On the Run",
                            TrackNo = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MediaCollection.Database.AlbumRating", b =>
                {
                    b.HasOne("MediaCollection.Database.Album", "Album")
                        .WithMany("Ratings")
                        .HasForeignKey("AlbumID");
                });

            modelBuilder.Entity("MediaCollection.Database.AlbumReview", b =>
                {
                    b.HasOne("MediaCollection.Database.Album", "Album")
                        .WithMany("Reviews")
                        .HasForeignKey("AlbumID");
                });

            modelBuilder.Entity("MediaCollection.Database.Episode", b =>
                {
                    b.HasOne("MediaCollection.Database.Serie", "Serie")
                        .WithMany("Episodes")
                        .HasForeignKey("SerieID");
                });

            modelBuilder.Entity("MediaCollection.Database.MovieRating", b =>
                {
                    b.HasOne("MediaCollection.Database.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieID");
                });

            modelBuilder.Entity("MediaCollection.Database.MovieReview", b =>
                {
                    b.HasOne("MediaCollection.Database.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieID");
                });

            modelBuilder.Entity("MediaCollection.Database.PodcastEpisode", b =>
                {
                    b.HasOne("MediaCollection.Database.Podcast", "Podcast")
                        .WithMany("Episodes")
                        .HasForeignKey("PodcastID");
                });

            modelBuilder.Entity("MediaCollection.Database.PodcastRating", b =>
                {
                    b.HasOne("MediaCollection.Database.Podcast", "Podcast")
                        .WithMany("Ratings")
                        .HasForeignKey("PodcastID");
                });

            modelBuilder.Entity("MediaCollection.Database.PodcastReview", b =>
                {
                    b.HasOne("MediaCollection.Database.Podcast", "Podcast")
                        .WithMany("Reviews")
                        .HasForeignKey("PodcastID");
                });

            modelBuilder.Entity("MediaCollection.Database.SerieRating", b =>
                {
                    b.HasOne("MediaCollection.Database.Serie", "Serie")
                        .WithMany("Ratings")
                        .HasForeignKey("SerieID");
                });

            modelBuilder.Entity("MediaCollection.Database.SerieReview", b =>
                {
                    b.HasOne("MediaCollection.Database.Serie", "Serie")
                        .WithMany("Reviews")
                        .HasForeignKey("SerieID");
                });

            modelBuilder.Entity("MediaCollection.Database.Track", b =>
                {
                    b.HasOne("MediaCollection.Database.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

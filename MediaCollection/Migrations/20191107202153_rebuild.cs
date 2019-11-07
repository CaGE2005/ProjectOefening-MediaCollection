using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Migrations
{
    public partial class rebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Genre = table.Column<string>(maxLength: 100, nullable: true),
                    AlbumArtist = table.Column<string>(maxLength: 100, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Synopsis = table.Column<string>(maxLength: 512, nullable: true),
                    Cover = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Genre = table.Column<string>(maxLength: 100, nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Synopsis = table.Column<string>(maxLength: 512, nullable: true),
                    Poster = table.Column<byte[]>(nullable: true),
                    Director = table.Column<string>(maxLength: 100, nullable: true),
                    Cast = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    PodcastID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Publisher = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Synopsis = table.Column<string>(maxLength: 512, nullable: true),
                    Poster = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.PodcastID);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SerieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Synopsis = table.Column<string>(maxLength: 512, nullable: true),
                    Genre = table.Column<string>(maxLength: 100, nullable: true),
                    Director = table.Column<string>(maxLength: 100, nullable: true),
                    Cast = table.Column<string>(maxLength: 100, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Poster = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SerieID);
                });

            migrationBuilder.CreateTable(
                name: "AlbumRatings",
                columns: table => new
                {
                    AlbumRatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    AlbumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumRatings", x => x.AlbumRatingID);
                    table.ForeignKey(
                        name: "FK_AlbumRatings_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlbumReviews",
                columns: table => new
                {
                    AlbumReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(maxLength: 2048, nullable: true),
                    User = table.Column<string>(nullable: true),
                    AlbumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumReviews", x => x.AlbumReviewID);
                    table.ForeignKey(
                        name: "FK_AlbumReviews_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackNo = table.Column<int>(nullable: false),
                    TrackName = table.Column<string>(maxLength: 100, nullable: true),
                    Artist = table.Column<string>(maxLength: 100, nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    AlbumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackID);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieRatings",
                columns: table => new
                {
                    MovieRatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    MovieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRatings", x => x.MovieRatingID);
                    table.ForeignKey(
                        name: "FK_MovieRatings_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieReviews",
                columns: table => new
                {
                    MovieReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(maxLength: 2048, nullable: true),
                    User = table.Column<string>(nullable: true),
                    MovieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReviews", x => x.MovieReviewID);
                    table.ForeignKey(
                        name: "FK_MovieReviews_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PodcastEpisodes",
                columns: table => new
                {
                    PodcastEpisodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpisodeNo = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Hosts = table.Column<string>(maxLength: 100, nullable: true),
                    Guests = table.Column<string>(maxLength: 100, nullable: true),
                    PodcastID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastEpisodes", x => x.PodcastEpisodeID);
                    table.ForeignKey(
                        name: "FK_PodcastEpisodes_Podcasts_PodcastID",
                        column: x => x.PodcastID,
                        principalTable: "Podcasts",
                        principalColumn: "PodcastID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PodcastRatings",
                columns: table => new
                {
                    PodcastRatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    PodcastID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastRatings", x => x.PodcastRatingID);
                    table.ForeignKey(
                        name: "FK_PodcastRatings_Podcasts_PodcastID",
                        column: x => x.PodcastID,
                        principalTable: "Podcasts",
                        principalColumn: "PodcastID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PodcastReviews",
                columns: table => new
                {
                    PodcastReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(maxLength: 2048, nullable: true),
                    User = table.Column<string>(nullable: true),
                    PodcastID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastReviews", x => x.PodcastReviewID);
                    table.ForeignKey(
                        name: "FK_PodcastReviews_Podcasts_PodcastID",
                        column: x => x.PodcastID,
                        principalTable: "Podcasts",
                        principalColumn: "PodcastID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    EpisodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Season = table.Column<int>(nullable: false),
                    EpisodeNo = table.Column<int>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Synopsis = table.Column<string>(maxLength: 512, nullable: true),
                    SerieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.EpisodeID);
                    table.ForeignKey(
                        name: "FK_Episodes_Series_SerieID",
                        column: x => x.SerieID,
                        principalTable: "Series",
                        principalColumn: "SerieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SerieRatings",
                columns: table => new
                {
                    SerieRatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    SerieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieRatings", x => x.SerieRatingID);
                    table.ForeignKey(
                        name: "FK_SerieRatings_Series_SerieID",
                        column: x => x.SerieID,
                        principalTable: "Series",
                        principalColumn: "SerieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SerieReviews",
                columns: table => new
                {
                    SerieReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(maxLength: 2048, nullable: true),
                    User = table.Column<string>(nullable: true),
                    SerieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieReviews", x => x.SerieReviewID);
                    table.ForeignKey(
                        name: "FK_SerieReviews_Series_SerieID",
                        column: x => x.SerieID,
                        principalTable: "Series",
                        principalColumn: "SerieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "AlbumArtist", "Cover", "Duration", "Genre", "ReleaseDate", "Synopsis", "Title" },
                values: new object[] { 1, "Pink Floyd", null, new TimeSpan(0, 0, 48, 0, 0), "Experimental Rock", new DateTime(1973, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Side of the Moon is the eighth studio album by English rock band Pink Floyd, released on 1 March 1973 by Harvest Records.Primarily developed during live performances, the band premiered an early version of the record several months before recording began.New material was recorded in two sessions in 1972 and 1973 at Abbey Road Studios in London.", "Dark Side of the Moon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Cast", "Director", "Duration", "Genre", "Poster", "ReleaseDate", "Synopsis", "Title" },
                values: new object[] { 1, "Tim Robbins, Morgan Freeman, Bob Gunton", "Frank Darabont", new TimeSpan(0, 2, 22, 0, 0), "Drama", null, new DateTime(1995, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "The Shawshank Redemption" });

            migrationBuilder.InsertData(
                table: "Podcasts",
                columns: new[] { "PodcastID", "Poster", "Publisher", "Synopsis", "Title" },
                values: new object[] { 1, null, "Begijn Le Blue", "Every week 3 new birds are discussed with professional bird-watchers.", "Fwiet! Fwiet!" });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "SerieID", "Cast", "Director", "Genre", "Poster", "ReleaseDate", "Synopsis", "Title" },
                values: new object[] { 1, "Emilia Clarke, Peter Dinklage, Kit Harrington", "D.B. Weiss, David Benioff", "Action, Adventure, Drama", null, new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nine noble families fight for control over the mythical lands of Westeros, while an ancient enemy returns after being dormant for thousands of years.", "Game of Thrones" });

            migrationBuilder.InsertData(
                table: "AlbumRatings",
                columns: new[] { "AlbumRatingID", "AlbumID", "Rating", "User" },
                values: new object[] { 1, 1, 9, "Cage2005@hotmail.com" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeID", "Duration", "EpisodeNo", "Season", "SerieID", "Synopsis" },
                values: new object[] { 1, new TimeSpan(0, 1, 2, 0, 0), 1, 1, 1, "Eddard Stark is torn between his family and an old friend when asked to serve at the side of King Robert Baratheon; Viserys plans to wed his sister to a nomadic warlord in exchange for an army." });

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "MovieRatingID", "MovieID", "Rating", "User" },
                values: new object[,]
                {
                    { 1, 1, 9, "cage2005@hotmail.com" },
                    { 2, 1, 8, "gerben.calus@vdab.be" }
                });

            migrationBuilder.InsertData(
                table: "MovieReviews",
                columns: new[] { "MovieReviewID", "MovieID", "Review", "User" },
                values: new object[,]
                {
                    { 1, 1, "Can Hollywood, usually creating things for entertainment purposes only, create art? To create something of this nature, a director must approach it in a most meticulous manner, due to the delicacy of the process. Such a daunting task requires an extremely capable artist with an undeniable managerial capacity and an acutely developed awareness of each element of art in their films, the most prominent; music, visuals, script, and acting. These elements, each equally important, must succeed independently, yet still form a harmonious union, because this mixture determines the fate of the artist's opus. Though already well known amongst his colleagues for his notable skills at writing and directing, Frank Darabont emerges with his feature film directorial debut, The Shawshank Redemption. Proving himself already a master of the craft, Darabont managed to create one of the most recognizable independent releases in the history of Hollywood. The Shawshank Redemption defines a genre, defies the odds, compels the emotions, and brings an era of artistically influential films back to Hollywood.", "cage2005@hotmail.com" },
                    { 2, 1, "Why do I want to write the 234th comment on The Shawshank Redemption? I am not sure - almost everything that could be possibly said about it has been said. But like so many other people who wrote comments, I was and am profoundly moved by this simple and eloquent depiction of hope and friendship and redemption.", "gerben.calus@vdab.be" }
                });

            migrationBuilder.InsertData(
                table: "PodcastEpisodes",
                columns: new[] { "PodcastEpisodeID", "Date", "Duration", "EpisodeNo", "Guests", "Hosts", "PodcastID", "Title" },
                values: new object[] { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 12, 45, 0), 1, "", "", 1, "De Specht" });

            migrationBuilder.InsertData(
                table: "SerieRatings",
                columns: new[] { "SerieRatingID", "Rating", "SerieID", "User" },
                values: new object[] { 1, 9, 1, "cage2005@hotmail.com" });

            migrationBuilder.InsertData(
                table: "SerieReviews",
                columns: new[] { "SerieReviewID", "Review", "SerieID", "User" },
                values: new object[] { 1, "It was a master piece. It was written to the perfection. It was mesmerizing. It was gripping. It was so shocking that if someone is binge watching this show he/she will need a time-off in between to get their head around things and accept some messed up, yet mind blowing development. But yet, I cant hate it enough after final season.Its like you came to know that you were in love with the wrong one all along.It was like looking at a completely different person.It was like seeing your own dreams and expectations get destroyed.It was not a let down, it was a BETRAYAL!", 1, "cage2005@hotmail.com" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "TrackID", "AlbumID", "Artist", "Duration", "TrackName", "TrackNo" },
                values: new object[,]
                {
                    { 1, 1, "Pink Floyd", new TimeSpan(0, 0, 1, 30, 0), "Speak to Me", 1 },
                    { 2, 1, "Pink Floyd", new TimeSpan(0, 0, 2, 43, 0), "Breathe", 2 },
                    { 3, 1, "Pink Floyd", new TimeSpan(0, 0, 3, 36, 0), "On the Run", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumRatings_AlbumID",
                table: "AlbumRatings",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumReviews_AlbumID",
                table: "AlbumReviews",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SerieID",
                table: "Episodes",
                column: "SerieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_MovieID",
                table: "MovieRatings",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_MovieID",
                table: "MovieReviews",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastEpisodes_PodcastID",
                table: "PodcastEpisodes",
                column: "PodcastID");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastRatings_PodcastID",
                table: "PodcastRatings",
                column: "PodcastID");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastReviews_PodcastID",
                table: "PodcastReviews",
                column: "PodcastID");

            migrationBuilder.CreateIndex(
                name: "IX_SerieRatings_SerieID",
                table: "SerieRatings",
                column: "SerieID");

            migrationBuilder.CreateIndex(
                name: "IX_SerieReviews_SerieID",
                table: "SerieReviews",
                column: "SerieID");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumID",
                table: "Tracks",
                column: "AlbumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumRatings");

            migrationBuilder.DropTable(
                name: "AlbumReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "MovieRatings");

            migrationBuilder.DropTable(
                name: "MovieReviews");

            migrationBuilder.DropTable(
                name: "PodcastEpisodes");

            migrationBuilder.DropTable(
                name: "PodcastRatings");

            migrationBuilder.DropTable(
                name: "PodcastReviews");

            migrationBuilder.DropTable(
                name: "SerieRatings");

            migrationBuilder.DropTable(
                name: "SerieReviews");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}

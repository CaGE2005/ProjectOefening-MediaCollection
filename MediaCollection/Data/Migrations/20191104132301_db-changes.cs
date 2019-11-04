using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Data.Migrations
{
    public partial class dbchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    AlbumArtist = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Cover = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Synopsis = table.Column<string>(nullable: true),
                    Poster = table.Column<byte[]>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Cast = table.Column<string>(nullable: true)
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
                    Publisher = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
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
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Cast = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Poster = table.Column<byte[]>(nullable: true),
                    Seasons = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SerieID);
                });

            migrationBuilder.CreateTable(
                name: "MusicRating",
                columns: table => new
                {
                    MusicRatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    AlbumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicRating", x => x.MusicRatingID);
                    table.ForeignKey(
                        name: "FK_MusicRating_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicReview",
                columns: table => new
                {
                    MusicReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    AlbumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicReview", x => x.MusicReviewID);
                    table.ForeignKey(
                        name: "FK_MusicReview_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    TrackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackNo = table.Column<int>(nullable: false),
                    TrackName = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Cover = table.Column<byte[]>(nullable: true),
                    AlbumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.TrackID);
                    table.ForeignKey(
                        name: "FK_Track_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieRating",
                columns: table => new
                {
                    MovieRatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(nullable: false),
                    MovieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRating", x => x.MovieRatingID);
                    table.ForeignKey(
                        name: "FK_MovieRating_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieReview",
                columns: table => new
                {
                    MovieReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(nullable: true),
                    MovieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReview", x => x.MovieReviewID);
                    table.ForeignKey(
                        name: "FK_MovieReview_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PodcastEpisode",
                columns: table => new
                {
                    PodcastEpisodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpisodeNo = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Hosts = table.Column<string>(nullable: true),
                    Guests = table.Column<string>(nullable: true),
                    PodcastID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastEpisode", x => x.PodcastEpisodeID);
                    table.ForeignKey(
                        name: "FK_PodcastEpisode_Podcasts_PodcastID",
                        column: x => x.PodcastID,
                        principalTable: "Podcasts",
                        principalColumn: "PodcastID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SerieRating",
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
                    table.PrimaryKey("PK_SerieRating", x => x.SerieRatingID);
                    table.ForeignKey(
                        name: "FK_SerieRating_Series_SerieID",
                        column: x => x.SerieID,
                        principalTable: "Series",
                        principalColumn: "SerieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SerieReview",
                columns: table => new
                {
                    SerieReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    SerieID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieReview", x => x.SerieReviewID);
                    table.ForeignKey(
                        name: "FK_SerieReview_Series_SerieID",
                        column: x => x.SerieID,
                        principalTable: "Series",
                        principalColumn: "SerieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieRating_MovieID",
                table: "MovieRating",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_MovieID",
                table: "MovieReview",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicRating_AlbumID",
                table: "MusicRating",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicReview_AlbumID",
                table: "MusicReview",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastEpisode_PodcastID",
                table: "PodcastEpisode",
                column: "PodcastID");

            migrationBuilder.CreateIndex(
                name: "IX_SerieRating_SerieID",
                table: "SerieRating",
                column: "SerieID");

            migrationBuilder.CreateIndex(
                name: "IX_SerieReview_SerieID",
                table: "SerieReview",
                column: "SerieID");

            migrationBuilder.CreateIndex(
                name: "IX_Track_AlbumID",
                table: "Track",
                column: "AlbumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieRating");

            migrationBuilder.DropTable(
                name: "MovieReview");

            migrationBuilder.DropTable(
                name: "MusicRating");

            migrationBuilder.DropTable(
                name: "MusicReview");

            migrationBuilder.DropTable(
                name: "PodcastEpisode");

            migrationBuilder.DropTable(
                name: "SerieRating");

            migrationBuilder.DropTable(
                name: "SerieReview");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poster = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                });
        }
    }
}

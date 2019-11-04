using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaWeb.Database
{
    public class Movie
    {
        public int MovieID { get; set; }      
        public string Title { get; set; }               
        public string Genre { get; set; }
        public int Duration { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
        public byte[] Poster { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }        
    }

    //public class MovieGenre
    //{
    //    public int MovieID { get; set; }
    //    public Movie Movie { get; set; }
    //    public int GenreID { get; set; }
    //    public Genre Genre { get; set; }       
    //}

    //public class MovieDirector
    //{
    //    public int MovieID { get; set; }
    //    public Movie Movie { get; set; }      
    //    public int DirectorID { get; set; }
    //    public Director Director { get; set; }
    //}

    //public class MovieActor
    //{ 
    //    public int MovieID { get; set; }
    //    public Movie Movie { get; set; }
    //    public int ActorID { get; set; }
    //    public Actor Actor { get; set; }
    //}

    //public class MovieRating
    //{
    //    public int MovieRatingID { get; set; }

    //    [Range(1,5)]
    //    public int Rating { get; set; }
    //    public User User { get; set; }
    //}

    //public class MovieReview
    //{
    //    public int MovieReviewID { get; set; }
    //    public string Review { get; set; }
    //    public User User { get; set; }
    //}
}

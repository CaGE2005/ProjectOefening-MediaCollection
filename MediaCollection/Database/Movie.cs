using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
    public class Movie
    {
        public int MovieID { get; set; }      
        public string Title { get; set; }               
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
        public byte[] Poster { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public ICollection<MovieRating> Ratings { get; set; }
        public ICollection<MovieReview> Reviews { get; set; }
    }

    public class MovieRating
    {
        public int MovieRatingID { get; set; }
        public int Rating { get; set; }
        public virtual Movie Movie { get; set; }
    }

    public class MovieReview
    {
        public int MovieReviewID { get; set; }
        public string Review { get; set; }
        public virtual Movie Movie { get; set; }
    }    
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
    public class Serie
    {
        public int SerieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] Poster { get; set; }
        public int Seasons { get; set; }
        public ICollection<SerieRating> Ratings { get; set; }
        public ICollection<SerieReview> Reviews { get; set; }
    }

    public class SerieRating
    {
        public int SerieRatingID { get; set; }
        public int Rating { get; set; }
        public string User { get; set; }
        public virtual Serie Serie { get; set; }
    }

    public class SerieReview
    { 
        public int SerieReviewID { get; set; }
        public string Review { get; set; }
        public string User { get; set; }
        public virtual Serie Serie { get; set; }
    }
}

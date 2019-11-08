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
        
        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        
        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Genre(s)")]
        public string Genre { get; set; }
                
        [Display(Name = "Duration")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Duration { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [StringLength(512)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }

        public byte[] Poster { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Director(s)")]
        public string Director { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Cast")]
        public string Cast { get; set; }

        public ICollection<MovieRating> Ratings { get; set; }
        public ICollection<MovieReview> Reviews { get; set; }
    }

    public class MovieRating
    {
        public int MovieRatingID { get; set; }

        [RegularExpression(@"[0-9]")]
        [Range(1,10)]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        public string User { get; set; }
        public virtual Movie Movie { get; set; }
    }

    public class MovieReview
    {
        public int MovieReviewID { get; set; }
        
        [StringLength(2048)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-]*$")]
        [Display(Name = "Review")]
        public string Review { get; set; }

        public string User { get; set; }

        public virtual Movie Movie { get; set; }
    }    
}

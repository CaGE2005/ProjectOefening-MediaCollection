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

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(512)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Genre(s)")]
        public string Genre { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Director(s)")]
        public string Director { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Cast")]
        public string Cast { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public byte[] Poster { get; set; }

        public ICollection<Episode> Episodes { get; set; }
        public ICollection<SerieRating> Ratings { get; set; }
        public ICollection<SerieReview> Reviews { get; set; }
    }

    public class Episode
    {
        public int EpisodeID { get; set; }
        
        [RegularExpression(@"0-9")]
        [Range(1, 99)]
        [Display(Name = "Season")]
        public int Season { get; set; }

        [RegularExpression(@"0-9")]
        [Range(1, 50)]
        [Display(Name = "Episode")]
        public int EpisodeNo { get; set; }

        [RegularExpression(@"0-9")]
        [Display(Name = "Duration")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Duration { get; set; }

        [StringLength(512)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }

        public virtual Serie Serie { get; set; }
    }

    public class SerieRating
    {
        public int SerieRatingID { get; set; }

        [RegularExpression(@"[0-9]")]
        [Range(1, 10)]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        public string User { get; set; }

        public virtual Serie Serie { get; set; }
    }

    public class SerieReview
    { 
        public int SerieReviewID { get; set; }

        [StringLength(2048)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Review")]
        public string Review { get; set; }

        public string User { get; set; }

        public virtual Serie Serie { get; set; }
    }
}

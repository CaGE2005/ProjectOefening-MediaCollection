using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
    public class Album
    {
        public int AlbumID { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-.,]*$")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-.,]*$")]
        [Display(Name = "Genre(s)")]
        public string Genre { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-.,]*$")]
        [Display(Name = "Artist(s)")]
        public string AlbumArtist { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
                
        [Display(Name = "Duration")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Duration { get; set; }

        [StringLength(512)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-.,]*$")]
        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }
        public byte[] Cover { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
        public virtual ICollection<AlbumRating> Ratings { get; set; }
        public virtual ICollection<AlbumReview> Reviews { get; set; }
    }    

    public class Track
    {       
        public int TrackID { get; set; }

        [RegularExpression(@"[0-9]")]
        [Range(1,100)]
        [Display(Name = "Track")]
        public int TrackNo { get; set; }
        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Title")]
        public string TrackName { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Artist(s)")]
        public string Artist { get; set; }

        [RegularExpression(@"[0-9]")]
        [Display(Name = "Duration")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Duration { get; set; }  
        
        public virtual Album Album { get; set; }
    }

    public class AlbumRating
    {       
        public int AlbumRatingID { get; set; }

        [RegularExpression(@"[0-9]")]
        [Range(1, 10)]
        [Display(Name = "Rating")]
        public int Rating { get; set; }   
        
        public string User { get; set; }     

        public virtual Album Album { get; set; }
    }

    public class AlbumReview
    {       
        public int AlbumReviewID { get; set; }

        [StringLength(2048)]
        [RegularExpression(@"^[A-Z0-9]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Review")]
        public string Review { get; set; }  
        
        public string User { get; set; }
        
        public virtual Album Album { get; set; }
    }
}

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
        public string Title { get; set; }
        public string Genre { get; set; }
        public string AlbumArtist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public byte[] Cover { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual ICollection<AlbumRating> Ratings { get; set; }
        public virtual ICollection<AlbumReview> Reviews { get; set; }
    }    

    public class Track
    {       
        public int TrackID { get; set; }
        public int TrackNo { get; set; }
        public string TrackName { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }        
        public virtual Album Album { get; set; }
    }

    public class AlbumRating
    {       
        public int AlbumRatingID { get; set; }
        public int Rating { get; set; }       
        public string User { get; set; }     
        public virtual Album Album { get; set; }
    }

    public class AlbumReview
    {       
        public int AlbumReviewID { get; set; }
        public string Review { get; set; }        
        public string User { get; set; }
        public virtual Album Album { get; set; }
    }
}

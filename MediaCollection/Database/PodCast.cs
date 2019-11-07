using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
    public class Podcast
    {
        public int PodcastID { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Podcast Title")]
        public string Title { get; set; }

        [StringLength(512)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }

        public byte[] Poster { get; set; }

        public ICollection<PodcastEpisode> Episodes { get; set; }
        public ICollection<PodcastRating> Ratings { get; set; }
        public ICollection<PodcastReview> Reviews { get; set; }
    }

    public class PodcastEpisode
    {
        public int PodcastEpisodeID { get; set; }

        [RegularExpression(@"[0-9]")]
        [Range(1, 10)]
        [Display(Name = "Episode #")]
        public int EpisodeNo { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Episode Title")]
        public string Title { get; set; }

        [RegularExpression(@"[0-9]")]
        [Display(Name = "Duration")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan Duration { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Host(s)")]
        public string Hosts { get; set; }

        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Guest(s)")]
        public string Guests { get; set; }

        public virtual Podcast Podcast { get; set; }
    }

    public class PodcastRating
    {
        public int PodcastRatingID { get; set; }

        [RegularExpression(@"[0-9]")]
        [Range(1, 10)]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        public virtual Podcast Podcast { get; set; }
    }

    public class PodcastReview
    {
        public int PodcastReviewID { get; set; }

        [StringLength(2048)]
        [RegularExpression(@"^[A-Z]+[0-9a-zA-Z""'\s-,.]*$")]
        [Display(Name = "Review")]
        public string Review { get; set; }
                
        public string User { get; set; }

        public virtual Podcast Podcast { get; set; }
    }
}

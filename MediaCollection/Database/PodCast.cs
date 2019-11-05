using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
        public class Podcast
        {
            public int PodcastID { get; set; }
            public string Publisher { get; set; }
            public string Title { get; set; }            
            public ICollection<PodcastEpisode> Episodes { get; set; }
            public byte[] Poster { get; set; }
            public ICollection<PodcastRating> Ratings { get; set; }
            public ICollection<PodcastReview> podcastReviews { get; set; }
        }       

        public class PodcastEpisode
        {
            public int PodcastEpisodeID { get; set; }
            public int EpisodeNo { get; set; }
            public string Title { get; set; }
            public TimeSpan Duration { get; set; }
            public DateTime Date { get; set; }
            public string Hosts { get; set; }
            public string Guests { get; set; }
        }

    public class PodcastRating
    {
        public int PodcastRatingID { get; set; }
        public int Rating { get; set; }
        public virtual Podcast Podcast { get; set; }
    }

    public class PodcastReview
    {
        public int PodcastReviewID { get; set; }
        public string Review { get; set; }
        public virtual Podcast Podcast { get; set; }
    }
}

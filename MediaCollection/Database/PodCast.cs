using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
        public class PodCast
        {
            public int PodcastID { get; set; }
            public string Publisher { get; set; }
            public string Title { get; set; }
            public DateTime StartDate { get; set; }
            public ICollection<PodcastEpisode> Episodes { get; set; }
            public byte[] Poster { get; set; }
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
}

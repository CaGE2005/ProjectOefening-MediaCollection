using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Database
{
    // Werkt niet zonder many-to-many database model

    //public class TrackPlayList
    //{
    //    public int TrackPlayListID { get; set; }
    //    public string User { get; set; }
    //    public ICollection<Track> Tracks { get; set; }
    //}
    //public class EpisodePlayList
    //{
    //    public int EpisodePlayListID { get; set; }
    //    public string User { get; set; }
    //    public ICollection<Episode> Episodes { get; set; }
    //}
    //public class MoviePlayList
    //{
    //    public int MoviePlayListID { get; set; }
    //    public string User { get; set; }
    //    public ICollection<Movie> Movies { get; set; }
    //}
    //public class PodCastEpisodePlayList
    //{
    //    public int PodcastEpisodePlayListID { get; set; }
    //    public string User { get; set; }
    //    public ICollection<PodcastEpisode> PodCastEpisodes { get; set; }
    //}

    // Werkt niet zonder telkens 4 lege velden aan te maken

    //public class PlayList
    //{
    //    public int PlayListID { get; set; }
    //    public String User { get; set; }
    //    public ICollection<PlayListItem<Movie>> PlayListItem { get; set; }        
    //} 

    //public class PlayListItem<TMedia>
    //{
    //    public int PlayListItemID { get; set; }
    //    public TMedia Media { get; set; }
    //    public virtual PlayList PlayList { get; set; }
    //}   
}

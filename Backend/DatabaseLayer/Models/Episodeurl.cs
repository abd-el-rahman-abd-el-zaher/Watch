using DatabaseLayer.Helper;

namespace DatabaseLayer.Models
{
    public class Episodeurl
    {
        public int EpisodeurlId { get; set; }    
        public string Url { get; set; } 
        public string HostName { get; set; }
        public Quality quality { get; set; }
        public UrlType UrlType { get; set; }    

        public int EpisodeId { get; set; }  
        public virtual Episode Episode { get; set; }

    }
}

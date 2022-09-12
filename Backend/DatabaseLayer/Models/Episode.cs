using DatabaseLayer.Helper;
namespace DatabaseLayer.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public string Title { get; set; }
        public int WatchCount { get; set; }
        public Filler Status { get; set; }
        
        public int AnimeId { get; set; }    
        public virtual Anime Anime { get; set; }

        public ICollection<Episodeurl> Episodeurls { get; set; }
    }
}

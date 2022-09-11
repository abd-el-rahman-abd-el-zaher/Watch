namespace DatabaseLayer.Models
{
    public class Anime
    {
        public int AnimeId { get; set; }
        public string Name { get; set; } 
        public string Story { get; set; }
        public string TeaserLink { get; set; }
        public DayOfWeek OutDay { get; set; }
        public string MalPage { get; set; }
        public string ReleaseDate { get; set; }
        public int EpisodesNumber { get; set; }
        public string Image { get; set; }
        public string Banner { get; set; }
        
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<AnimeGenres> AnimeGenres { get; set; }    

        public virtual ICollection<Episode> Episodes { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }

    }
}

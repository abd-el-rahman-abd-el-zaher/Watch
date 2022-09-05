namespace DatabaseLayer.Models
{
    public class AnimeGenres
    {
        public int AnimeId { get; set; }
        public virtual Anime Anime { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}

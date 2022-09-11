namespace DatabaseLayer.Models
{
    public  class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AnimeGenres> AnimeGenres { get; set; }

    }
}

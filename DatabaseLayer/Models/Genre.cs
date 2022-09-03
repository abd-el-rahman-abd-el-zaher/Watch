namespace DatabaseLayer.Models
{
    public  class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Anime> Animes { get; set; }

    }
}

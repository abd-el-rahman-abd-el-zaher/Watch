using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.Configrations
{
    public class AnimeGenresConfiguration : IEntityTypeConfiguration<AnimeGenres>
    {
        public void Configure(EntityTypeBuilder<AnimeGenres> builder)
        {
            builder.HasKey(ag => new { ag.AnimeId, ag.GenreId });
            builder.HasOne(ag => ag.Anime).WithMany(a=>a.AnimeGenres);
            builder.HasOne(ag => ag.Genre).WithMany(g => g.AnimeGenres);
        }
    }
}

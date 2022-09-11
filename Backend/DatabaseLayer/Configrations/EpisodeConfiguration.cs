using DatabaseLayer.Helper;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.Configrations
{
    public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.HasOne(episode => episode.Anime).WithMany(anime => anime.Episodes);
            builder.Property(e => e.Status).HasConversion(
                                        v => v.ToString(),
                                        v => (Filler)Enum.Parse(typeof(Filler), v));
        }
    }
}
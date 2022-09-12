using DatabaseLayer.Helper;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseLayer.Configrations
{
    public class EpisodeurlConfiguration : IEntityTypeConfiguration<Episodeurl>
    {
        public void Configure(EntityTypeBuilder<Episodeurl> builder)
        {
            builder.HasOne(episodeurl => episodeurl.Episode).WithMany(e => e.Episodeurls);
            builder.Property(eu => eu.quality).HasConversion(
                                        v => v.ToString(),
                                        v => (Quality)Enum.Parse(typeof(Quality), v));
            builder.Property(eu => eu.UrlType).HasConversion(
                                        v => v.ToString(),
                                        v => (UrlType)Enum.Parse(typeof(UrlType), v));
        }
    }
}
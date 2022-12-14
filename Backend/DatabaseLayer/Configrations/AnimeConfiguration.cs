using DatabaseLayer.Helper;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Configrations
{
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder.HasOne(anime => anime.User).WithMany(user => user.Animes);
            builder.HasOne(anime => anime.Category).WithMany(category => category.Animes);
            builder.Property(a => a.OutDay).HasConversion(
                                         v => v.ToString(),
                                         v => (DayOfWeek)Enum.Parse(typeof(DayOfWeek), v));
            builder.Property(a => a.ReleaseDate).HasColumnType("date");
               
            

        }
    }
}

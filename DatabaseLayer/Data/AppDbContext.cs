using DatabaseLayer.Configrations;
using DatabaseLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DatabaseLayer.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=watch;trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AnimeConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new AnimeGenresConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new FavoriteConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Anime> Animes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
    }
}

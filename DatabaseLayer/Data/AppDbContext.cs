using Microsoft.EntityFrameworkCore;


namespace DatabaseLayer.Data
{
    public class AppDbContext:DbContext
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

    }
}

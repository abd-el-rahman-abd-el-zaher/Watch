using API_Layer.Repositories.Interfaces;
using DatabaseLayer.Data;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Layer.Repositories
{
    public class FavAnimeRepository : IFavAnimeRepository
    {
        private readonly AppDbContext context;

        public FavAnimeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Anime>> FavsAnimes(string userId)
        {
            var favsAnimes = await (from fav in context.Favorites
                                    join anime in context.Animes
                                    on fav.AnimeId equals anime.AnimeId
                                    where fav.UserId == userId
                                    select anime).ToListAsync();

            return favsAnimes;
        }

        public async Task<bool> toggleFavs(string userId, int AnimeId)
        {
            var fav = await context.Favorites.Where(f =>( f.UserId == userId && f.AnimeId == AnimeId)).SingleOrDefaultAsync();
            if (fav == null)
            {
                Favorite favorite = new Favorite()
                {
                    AnimeId = AnimeId,
                    UserId = userId
                };
                await context.AddAsync(favorite);
                await context.SaveChangesAsync();
                 return (true);
                
            }
            else
            {
              context.Remove(fav);
                await context.SaveChangesAsync();
                return (false);
                
            }
            
        }
    }
}

using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using DatabaseLayer.Data;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Layer.Repositories
{
    public class EpisodeRepository : IEpisodeReposatory
    {
        private readonly AppDbContext context;

        public EpisodeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Add(NewEpisode newEpisode)
        {
            

           Episode episode = new Episode()
           {
               AnimeId = newEpisode.AnimeId,
               Title = newEpisode.Title,
               Status = newEpisode.Status,
               ReleaseDate = DateTime.Now               
               
           };
            context.AddAsync(episode);
            context.SaveChanges();
        }

        public async Task<Episode> Get(int id)
        {
            return await context.Episodes.Where(e => e.EpisodeId == id).SingleOrDefaultAsync();
        }

      

        public async Task<List<Episode>> GetAll(int AnimeId)
        {
            return await context.Episodes.Where(e => e.AnimeId == AnimeId).ToListAsync();
        }
    }
}

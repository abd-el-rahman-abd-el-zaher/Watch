using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using DatabaseLayer.Data;
using DatabaseLayer.Models;

namespace API_Layer.Repositories
{
    public class EpisodeRepository : IEpisodeInterface
    {
        private readonly AppDbContext context;

        public EpisodeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Task Add(NewEpisode newEpisode)
        {
            throw new NotImplementedException();
        }

        public Task<Episode> Get(int id)
        {
            throw new NotImplementedException();
        }

      

        public async Task<List<Episode>> GetAll(int AnimeId)
        {
            //   return context.Episodes.Where(e => e.AnimeId == AnimeId)
            throw new NotImplementedException();
        }
    }
}

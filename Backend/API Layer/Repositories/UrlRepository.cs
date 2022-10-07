using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using DatabaseLayer.Data;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Layer.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        private readonly AppDbContext context;

        public UrlRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Add(NewEpisodeUrl newEpisodeUrl)
        {
            Episodeurl episodeurl = new Episodeurl()
            {
                EpisodeId = newEpisodeUrl.EpisodeId,
                Url = newEpisodeUrl.Url,
                HostName = newEpisodeUrl.HostName,
                quality = newEpisodeUrl.quality,
                UrlType = newEpisodeUrl.UrlType
            };
           await context.AddAsync(episodeurl);
            await context.SaveChangesAsync();
        }

        public async Task<List<Episodeurl>> GetAll(int EpisodeId)
        {
            return await context.Episodeurls.Where(eUrl=> eUrl.EpisodeId == EpisodeId).ToListAsync();
        }
    }
}

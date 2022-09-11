using API_Layer.DataModels;
using DatabaseLayer.Models;

namespace API_Layer.Repositories.Interfaces
{
    public interface IEpisodeReposatory
    {
        Task<List<Episode>> GetAll(int AnimeId);
        Task<Episode> Get(int id);
        Task Add(NewEpisode newEpisode);
    }
}

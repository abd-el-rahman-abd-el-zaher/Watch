using API_Layer.DataModels;
using DatabaseLayer.Models;

namespace API_Layer.Repositories.Interfaces
{
    public interface IUrlRepository
    {
        Task<List<Episodeurl>> GetAll(int EpisodeId);
        Task Add(NewEpisodeUrl newEpisodeUrl);
    }
}

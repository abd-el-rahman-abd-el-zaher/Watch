using DatabaseLayer.Models;

namespace API_Layer.Repositories.Interfaces
{
    public interface IFavAnimeRepository
    {
        Task<List<Anime>> FavsAnimes(string userId);
        Task<bool> toggleFavs(string userId,int AnimeId);
    }
}

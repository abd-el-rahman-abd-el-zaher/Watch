using API_Layer.DataModels;
using DatabaseLayer.Models;

namespace API_Layer.Repositories.Interfaces
{
    public interface IAnimeRepository
    {
        Task<List<Anime>> GetAll();
        Task<Anime> Get(int id);
        Task Add(NewAnime newAnime);    

    }
}

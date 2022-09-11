using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using DatabaseLayer.Data;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Layer.Repositories
{
    public class AnimeRepository :IAnimeRepository
    {
        private readonly AppDbContext context;

        public AnimeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Anime>> GetAll()
        {
            return await context.Animes.ToListAsync();
        }

        public async Task<Anime> Get(int id)
        {
            return await context.Animes.FindAsync(id);
        }

       public async Task Add(NewAnime newAnime)
        {
            Anime anime = new Anime() { Name=newAnime.Name,Story=newAnime.Story,OutDay=newAnime.OutDay,
                                        TeaserLink=newAnime.TeaserLink,ReleaseDate=newAnime.ReleaseDate,
                                        MalPage=newAnime.MalPage,EpisodesNumber=newAnime.EpisodesNumber,
                                        CategoryId=newAnime.CategoryId,UserId=newAnime.UserId,
                                        Image=newAnime.Image};

            await context.AddAsync(anime);
            await context.SaveChangesAsync();
        }
    }
}

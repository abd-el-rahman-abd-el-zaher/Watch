using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using DatabaseLayer.Data;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Layer.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment hostEnvironment;

        public AnimeRepository(AppDbContext context, IWebHostEnvironment hostEnvironment)
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
            if (newAnime.Image.Length>0)
            {


                Anime anime = new Anime()
                {
                    Name = newAnime.Name,
                    Story = newAnime.Story,
                    OutDay = newAnime.OutDay,
                    TeaserLink = newAnime.TeaserLink,
                    ReleaseDate = newAnime.ReleaseDate,
                    MalPage = newAnime.MalPage,
                    EpisodesNumber = newAnime.EpisodesNumber,
                    CategoryId = newAnime.CategoryId,
                    UserId = newAnime.UserId
                };
                await context.AddAsync(anime);
                await context.SaveChangesAsync();

                
                var filePath = Path.Combine(hostEnvironment.WebRootPath, $@"Images\Anime\Main");
                string fileName = $"{anime.AnimeId}-{anime.Name}";
                var fullPath = Path.Combine(filePath, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await newAnime.Image.CopyToAsync(stream);
                }
                anime.Image = fileName;
                await context.SaveChangesAsync();

            }
            else
            {
                throw new Exception("Image Required");
            }
        }
    }
}

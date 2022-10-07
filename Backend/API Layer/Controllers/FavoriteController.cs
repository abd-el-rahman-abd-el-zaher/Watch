using API_Layer.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavAnimeRepository favAnimeRepository;

        public FavoriteController(IFavAnimeRepository favAnimeRepository)
        {
            this.favAnimeRepository = favAnimeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(string userId)
        {
            return Ok(await favAnimeRepository.FavsAnimes(userId));
        }
        [HttpPost]
        public async Task<IActionResult> ToogleFavs(string userId,int animeId)
        {
            try
            {

          bool res =  await favAnimeRepository.toggleFavs(userId, animeId);
       
                if (res)
                {
                return Ok("Added");

                }
                else
                {
                    return Ok("removed");
                }
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }
    }
}

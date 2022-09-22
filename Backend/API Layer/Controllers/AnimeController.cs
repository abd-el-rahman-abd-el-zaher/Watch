using API_Layer.DataModels;
using API_Layer.Repositories;
using API_Layer.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeRepository animeRepository;

        public AnimeController(IAnimeRepository animeRepository)
        {
            this.animeRepository = animeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await animeRepository.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await animeRepository.Get(id));
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] NewAnime newAnime)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await animeRepository.Add(newAnime);
                    return Created("url", newAnime);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
            
        }
    }
}

using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeReposatory episodeReposatory;

        public EpisodeController(IEpisodeReposatory episodeReposatory)
        {
            this.episodeReposatory = episodeReposatory;
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var episode = await episodeReposatory.Get(id);
            if (episode != null)
            {
                return Ok(episode);
            }
            else
            {
                return BadRequest("No Episode Found");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int animeId)
        {
            return Ok(await episodeReposatory.GetAll(animeId));
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] NewEpisode newEpisode)
        {
                if (ModelState.IsValid)
                {
                    try
                    {
                        await episodeReposatory.Add(newEpisode);
                        return Created("url", newEpisode);
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

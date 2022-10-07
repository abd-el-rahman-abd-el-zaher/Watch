using API_Layer.DataModels;
using API_Layer.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        private readonly IUrlRepository urlRepository;

        public UrlController(IUrlRepository urlRepository)
        {
            this.urlRepository = urlRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int EpisodeUrl)
        {
            return Ok(await urlRepository.GetAll(EpisodeUrl));
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] NewEpisodeUrl newEpisodeUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await urlRepository.Add(newEpisodeUrl);
                    return Created("url", newEpisodeUrl);
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

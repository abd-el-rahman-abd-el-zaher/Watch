using DatabaseLayer.Helper;
using System.ComponentModel.DataAnnotations;

namespace API_Layer.DataModels
{
    public class NewEpisode
    {
        [Required(ErrorMessage ="Please Enterthe episode Title ")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please select the Episode Status")]
        [Range(0, 1, ErrorMessage = "Please enter correct value for status")]
        public Filler Status { get; set; }
        [Required(ErrorMessage ="PLease select An Anime")]
        public int AnimeId { get; set; }
    }
}

using DatabaseLayer.Helper;
using System.ComponentModel.DataAnnotations;

namespace API_Layer.DataModels
{
    public class NewEpisodeUrl
    {
        [Required(ErrorMessage = "Please Enterthe The episode URl ")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Please Enterthe The Host Name ")]
        public string HostName { get; set; }
        [Required(ErrorMessage = "Please select an Episode's Quality")]
        [Range(0, 2, ErrorMessage = "Please enter correct value for quality")]
        public Quality quality { get; set; }
        [Required(ErrorMessage = "Please select the Url Type")]
        [Range(0, 2, ErrorMessage = "Please enter the correct value for url Type")]
        public UrlType UrlType { get; set; }
        [Required(ErrorMessage = "Please Enterthe The episode ID ")]
        public int EpisodeId { get; set; }
    }
}

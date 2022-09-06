using System.ComponentModel.DataAnnotations;

namespace API_Layer.DataModels
{
    public class NewAnime
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Story { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string TeaserLink { get; set; }
        [Required(ErrorMessage = "Please Select the Out Day")]
        public DayOfWeek OutDay { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string MalPage { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }

        public int EpisodesNumber { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string UserId { get; set; }
        public int CategoryId { get; set; }
    }
}

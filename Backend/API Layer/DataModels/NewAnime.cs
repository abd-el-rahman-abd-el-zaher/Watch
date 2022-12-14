using System.ComponentModel.DataAnnotations;

namespace API_Layer.DataModels
{
    public class NewAnime
    {

        [Required(ErrorMessage = "Please Enter The Anime name  ")]
        public string Name { get; set; }
        [Required]
        public string Story { get; set; }
        [Required]
       [RegularExpression(@"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)",ErrorMessage = "Please Enter a valid url  ")]
        public string TeaserLink { get; set; }
        [Required(ErrorMessage = "Please Select the Out Day")]
        [Range(0, 6, ErrorMessage = "Please enter correct value for OutDay")]
        public DayOfWeek OutDay { get; set; }
        [Required]
       [RegularExpression(@"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)",ErrorMessage = "Please Enter a valid url  ")]
        public string MalPage { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Please Enter Episodes Count  ")]
        public int EpisodesNumber { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public string UserId { get; set; }
        public int CategoryId { get; set; }
    }
}

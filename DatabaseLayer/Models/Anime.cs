using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models
{
    public class Anime
    {
        public int AnimeId { get; set; }
        public string Name { get; set; } 
        public string Story { get; set; }
        public string TeaserLink { get; set; }
        public DayOfWeek OutDay { get; set; }
        public string MalPage { get; set; }
        public string ReleaseDate { get; set; }
        public int EpisodesNumber { get; set; }
        public string Image { get; set; }
        public string Banner { get; set; }
        
    }
}

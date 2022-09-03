using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models
{
    public class Favorite
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int AnimeId { get; set; }
        public virtual Anime Anime { get; set; }
    }
}

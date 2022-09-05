using Microsoft.AspNetCore.Identity;

namespace DatabaseLayer.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Anime> Animes { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}

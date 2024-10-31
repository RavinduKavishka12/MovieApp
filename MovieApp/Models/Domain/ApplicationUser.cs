using Microsoft.AspNetCore.Identity;

namespace MovieApp.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name{ get; set; }
    }
}

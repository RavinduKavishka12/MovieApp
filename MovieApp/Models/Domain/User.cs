using Microsoft.AspNetCore.Identity;

namespace MovieApp.Models.Domain
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}

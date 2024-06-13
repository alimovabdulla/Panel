using Microsoft.AspNetCore.Identity;

namespace FirstProject.Entities
{
    public class AppUser:IdentityUser
    {
        public string Password { get; set; }
    }
}

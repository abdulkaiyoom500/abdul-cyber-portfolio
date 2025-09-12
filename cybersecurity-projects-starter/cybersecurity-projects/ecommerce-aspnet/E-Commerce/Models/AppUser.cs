using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}

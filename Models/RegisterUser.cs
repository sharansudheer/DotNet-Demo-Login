using Microsoft.AspNetCore.Identity;

namespace MVCLogin.Models
{
    public class RegisterUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
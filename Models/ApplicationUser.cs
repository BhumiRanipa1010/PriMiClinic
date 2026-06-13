using Microsoft.AspNetCore.Identity;

namespace PriMiClinic.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
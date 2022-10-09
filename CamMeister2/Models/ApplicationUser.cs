using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CamMeister2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Points { get; set; } = 0;

        public virtual ICollection<Camera> Cameras { get; set; }

    }
}

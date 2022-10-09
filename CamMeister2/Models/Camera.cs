using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamMeister2.Models
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public string CamDescription { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string? ApplicationUserId { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }

        [NotMapped]
        public IFormFile? CameraPhoto { get; set; } 
        public string? CameraPhotoURL { get; set; }
    }
}

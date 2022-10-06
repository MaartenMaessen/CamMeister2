using System.ComponentModel.DataAnnotations;

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
    }
}

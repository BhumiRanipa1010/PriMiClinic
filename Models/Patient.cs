using System.ComponentModel.DataAnnotations;

namespace PriMiClinic.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
    }
}
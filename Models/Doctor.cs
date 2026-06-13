using System.ComponentModel.DataAnnotations;

namespace PriMiClinic.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Specialization { get; set; } = string.Empty;

        public string? UserId { get; set; }

        [Required]
        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
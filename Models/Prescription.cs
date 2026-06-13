using System.ComponentModel.DataAnnotations;

namespace PriMiClinic.Models
{
    public class Prescription
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public Patient? Patient { get; set; }

        [Required]
        public string Medicines { get; set; } = string.Empty;

        public string? Notes { get; set; }
    }
}
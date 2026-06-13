using System.ComponentModel.DataAnnotations;

namespace PriMiClinic.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; } = "Pending";

        public Doctor? Doctor { get; set; }

        public Patient? Patient { get; set; }
    }
}
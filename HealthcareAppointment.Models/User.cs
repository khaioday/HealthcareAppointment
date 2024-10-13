using System;
using System.ComponentModel.DataAnnotations;

namespace HealthcareAppointment.Models
{
    public enum Role
    {
        Patient,
        Doctor
    }

    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MinLength(3), MaxLength(255)]
        public string Name { get; set; }

        [Required, EmailAddress, MinLength(5), MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public Role Role { get; set; }

        [MinLength(3), MaxLength(255)]
        public string Specialization { get; set; }  // For doctors only

        [Required, MinLength(8)]
        public string Password { get; set; }
    }
}

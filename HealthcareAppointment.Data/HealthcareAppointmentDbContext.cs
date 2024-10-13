using HealthcareAppointment.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcareAppointment.Data
{
    public class HealthcareAppointmentDbContext : DbContext
    {
        public HealthcareAppointmentDbContext(DbContextOptions<HealthcareAppointmentDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. John Doe",
                    Email = "john.doe@hospital.com",
                    Role = Role.Doctor,
                    Specialization = "Cardiology",
                    Password = "Password@123"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Smith",
                    Email = "jane.smith@patient.com",
                    Role = Role.Patient,
                    Password = "Password@123"
                }
            );
        }
    }
}

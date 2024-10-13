using HealthcareAppointment.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthcareAppointment.Data
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetAppointmentsAsync();           // Get all appointments
        Task<Appointment> GetAppointmentByIdAsync(Guid id);            // Get appointment by ID
        Task AddAppointmentAsync(Appointment appointment);              // Add a new appointment
        Task UpdateAppointmentAsync(Appointment appointment);           // Update an existing appointment
        Task DeleteAppointmentAsync(Guid id);                           // Delete an appointment by ID
    }
}

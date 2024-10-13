using HealthcareAppointment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthcareAppointment.Data
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly HealthcareAppointmentDbContext _context;

        public AppointmentRepository(HealthcareAppointmentDbContext context)
        {
            _context = context;
        }

        // Get all appointments
        public async Task<IEnumerable<Appointment>> GetAppointmentsAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        // Get an appointment by its ID
        public async Task<Appointment> GetAppointmentByIdAsync(Guid id)
        {
            return await _context.Appointments.FindAsync(id);
        }

        // Add a new appointment
        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }

        // Update an existing appointment
        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }

        // Delete an appointment by its ID
        public async Task DeleteAppointmentAsync(Guid id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }
    }
}

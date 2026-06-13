using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PriMiClinic.Data;
using PriMiClinic.Models;
using Microsoft.AspNetCore.Authorization;

namespace PriMiClinic.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var appointments = _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .ToList();

            return View(appointments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Doctors =
                new SelectList(_context.Doctors, "Id", "Name");

            ViewBag.Patients =
                new SelectList(_context.Patients, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            var existingAppointment = _context.Appointments
                .FirstOrDefault(a =>
                    a.DoctorId == appointment.DoctorId &&
                    a.AppointmentDate == appointment.AppointmentDate);

            if (existingAppointment != null)
            {
                ModelState.AddModelError("",
                    "This doctor already has an appointment at the selected time.");
            }

            if (ModelState.IsValid)
            {
                _context.Appointments.Add(appointment);
                _context.SaveChanges();

                TempData["Success"] = "Appointment booked successfully.";

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Doctors =
                new SelectList(_context.Doctors, "Id", "Name");

            ViewBag.Patients =
                new SelectList(_context.Patients, "Id", "Name");

            return View(appointment);
        }

        public IActionResult Confirm(int id)
        {
            var appointment = _context.Appointments.Find(id);

            if (appointment != null)
            {
                appointment.Status = "Confirmed";
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Complete(int id)
        {
            var appointment = _context.Appointments.Find(id);

            if (appointment != null)
            {
                appointment.Status = "Completed";
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Cancel(int id)
        {
            var appointment = _context.Appointments.Find(id);

            if (appointment != null)
            {
                appointment.Status = "Cancelled";
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
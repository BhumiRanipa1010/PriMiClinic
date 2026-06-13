using Microsoft.AspNetCore.Mvc;
using PriMiClinic.Data;

namespace PriMiClinic.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.TotalDoctors = _context.Doctors.Count();
            ViewBag.TotalPatients = _context.Patients.Count();
            ViewBag.TotalAppointments = _context.Appointments.Count();
            ViewBag.TotalPrescriptions = _context.Prescriptions.Count();

            return View();
        }
    }
}
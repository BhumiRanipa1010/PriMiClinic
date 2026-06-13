using Microsoft.AspNetCore.Mvc;
using PriMiClinic.Data;
using PriMiClinic.Models;
using Microsoft.AspNetCore.Authorization;

namespace PriMiClinic.Controllers
{
    [Authorize]
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var doctors = _context.Doctors.ToList();
            return View(doctors);
        }

        // GET: Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var doctor = _context.Doctors.Find(id);

            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        // POST: Edit
        [HttpPost]
        public IActionResult Edit(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Doctors.Update(doctor);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(doctor);
        }

        // Delete
        public IActionResult Delete(int id)
        {
            var doctor = _context.Doctors.Find(id);

            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Doctors.Add(doctor);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(doctor);
        }
    }
}
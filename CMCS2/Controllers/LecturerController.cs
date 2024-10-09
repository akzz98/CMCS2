using CMCS2.Data;
using CMCS2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMCS2.Controllers
{
    public class LecturerController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;

        public LecturerController(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            _environment = environment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitClaim(double hoursWorked, double hourlyRate, string notes, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var claim = new Claim
                {
                    HoursWorked = hoursWorked,
                    HourlyRate = hourlyRate,
                    Notes = notes,
                    Status = "Pending"  // Default status is 'Pending'
                };

                // Handle file upload
                if (file != null && file.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    claim.DocumentPath = uniqueFileName;
                }

                // Save the claim to the database
                _context.Claims.Add(claim);
                await _context.SaveChangesAsync();

                return RedirectToAction("ClaimSubmitted");
            }

            return View();
        }

        public ActionResult UploadDocuments()
        {
            return View();
        }

        public ActionResult TrackStatus()
        {
            var claims = _context.Claims.ToList();
            return View();
        }

        public ActionResult VerifyClaims()
        {
            return View();
        }

    }
}

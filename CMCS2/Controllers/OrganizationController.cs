using CMCS2.Data;
using Microsoft.AspNetCore.Mvc;

namespace CMCS2.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrganizationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ViewUnapprovedClaims()
        {
            var unapprovedClaims = _context.Claims.Where(c => c.Status == "Pending").ToList();
            return View(unapprovedClaims);
        }

        public ActionResult ViewVerifiedClaims()
        {
            var verifiedClaims = _context.Claims.Where(c => c.Status == "Verified").ToList();
            return View(verifiedClaims);
        }

        public ActionResult ViewApprovedClaims()
        {
            var approvedClaims = _context.Claims.Where(c => c.Status == "Approved").ToList();
            return View(approvedClaims);
        }
    }
}

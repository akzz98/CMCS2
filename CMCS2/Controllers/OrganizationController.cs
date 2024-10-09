using Microsoft.AspNetCore.Mvc;

namespace CMCS2.Controllers
{
    public class OrganizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ViewUnapprovedClaims()
        {
            return View();
        }

        public ActionResult ViewVerifiedClaims()
        {
            return View();
        }

        public ActionResult ViewApprovedClaims()
        {
            return View();
        }
    }
}

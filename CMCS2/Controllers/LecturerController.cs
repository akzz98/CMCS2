using Microsoft.AspNetCore.Mvc;

namespace CMCS2.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult SubmitClaim()
        {
            return View();
        }

        public ActionResult UploadDocuments()
        {
            return View();
        }

        public ActionResult TrackStatus()
        {
            return View();
        }

        public ActionResult VerifyClaims()
        {
            return View();
        }

    }
}

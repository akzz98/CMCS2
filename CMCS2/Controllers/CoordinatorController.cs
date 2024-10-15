using CMCS2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMCS2.Controllers
{
    [Authorize(Roles = "Coordinator, Manager")]
    public class CoordinatorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoordinatorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Coordinator approves a claim (moves status to 'Verified')
        public async Task<IActionResult> ApproveClaim(int claimId)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.ClaimId == claimId);

            if (claim != null && claim.Status == "Pending")
            {
                claim.Status = "Verified";
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("ViewUnapprovedClaims", "Organization");
        }

        // Coordinator rejects a claim (moves status to 'Rejected')
        public async Task<IActionResult> RejectClaim(int claimId)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.ClaimId == claimId);

            if (claim != null && claim.Status == "Pending")
            {
                claim.Status = "Rejected";
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("ViewUnapprovedClaims", "Organization");
        }

        // Manager finalizes approval (moves status to 'Approved')
        public async Task<IActionResult> FinalizeApproval(int claimId)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.ClaimId == claimId);

            if (claim != null && claim.Status == "Verified")
            {
                claim.Status = "Approved";
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("ViewVerifiedClaims", "Organization");
        }

        // Manager rejects a verified claim (moves status to 'Rejected')
        public async Task<IActionResult> RejectVerifiedClaim(int claimId)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.ClaimId == claimId);

            if (claim != null && claim.Status == "Verified")
            {
                claim.Status = "Rejected";
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("ViewVerifiedClaims", "Organization");
        }
    }
}
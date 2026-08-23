using Lecturer_Claim_Register.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lecturer_Claim_Register.Controllers
{
    public class HomeController : Controller
    {
        //stores the number for the  next id
        private static int nextClaimId = 1;


        //in memory list of claims
        private readonly List<Claimmodel> claims = new()
        {
            new Claimmodel
            {
                ClaimId = nextClaimId++, 
                LecturerName = "Castle Doe",
                ModuleCode = "CS101",
                HoursWorked = 10.0, 
                HourlyRate = 250.00m,
                ClaimMonth = "May 2026",
                Status ="Draft"

            },
            new Claimmodel
            {
                ClaimId = nextClaimId++, 
                LecturerName = "Jane Mokoena", 
                ModuleCode = "DV422", 
                HoursWorked = 8.0, 
                HourlyRate = 490.00m,
                ClaimMonth = "June 2026",
                Status = "Draft"
            },
        };
        //method to get all claims
        public List<Claimmodel> GetAll() => claims;

        public void AddClaim(Claimmodel claim)
        {
            claim.ClaimId = nextClaimId++;
            claims.Add(claim);
        }

        //Display list and entry form
        [HttpGet]
        public IActionResult Index()
        {
            return View(GetAll());
        }
         
        //create claim
        [HttpGet]
        public IActionResult CreateClaim()
        {
            return View(new Claimmodel());
        }

        //create claim
        [HttpPost]
        public IActionResult CreateClaim(Claimmodel claim)
        {
            AddClaim(claim);
            return RedirectToAction("Index");
        }

        //restful endpoint returns claims as json
        [HttpGet("api/claims")]
        public IActionResult GetClaims()
        {
            return Json(GetAll());
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}

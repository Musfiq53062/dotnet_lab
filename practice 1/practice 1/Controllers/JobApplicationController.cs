using Microsoft.AspNetCore.Mvc;
using practice_1.Models;

namespace practice_1.Controllers
{
    public class JobApplicationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(JobApplication application)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success",
                    new { name = application.ApplicantName });
            }

            return View(application);
        }

        [HttpGet]
        public IActionResult Success(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}

using _530623.Models;
using Microsoft.AspNetCore.Mvc;

namespace _530623.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View(course);
            }
            else
            {
                return View(course);
            }
        }

        
    }
}

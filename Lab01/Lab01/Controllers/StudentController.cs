using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Student.List";
            ViewBag.Message = "Welcome to the Student Page";
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();

        }

        public IActionResult About()
        {
            return Content("This is the Student Page");
        }
    }
}

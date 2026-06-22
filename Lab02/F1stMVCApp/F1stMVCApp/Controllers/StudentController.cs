using Microsoft.AspNetCore.Mvc;

namespace F1stMVCApp.Controllers
{
    public class StudentController : Controller
    {
        //displays the student list
        public IActionResult Index()
        {
            ViewBag.Title = "Student List";
            ViewBag.Message = "Welcome to the student module";
            return View();
        }
        //displays details for a specific student
        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }

        public IActionResult About()
        {
            return Content("This is the student module");
        }
    }
}

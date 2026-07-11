using Microsoft.AspNetCore.Mvc;

namespace F1stMVCApp.Controllers
{
    public class StudentController : Controller
    {
        //displays the student list
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Student List";
            ViewData["SubTitle"] = "Enrolled students this semester";

            var students = new List<string>
            {
                "Alice Rahman", "Bob Hasan", "Carol Akter", "David Khan"
            };

            return View(students);
        }
        [HttpPost]
        public IActionResult Index(string fullName, string email)
        {
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

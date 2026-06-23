using Microsoft.AspNetCore.Mvc;
namespace F1stMVCApp.Controllers
{
    [Route("courses")]
    public class CourseController : Controller
    {

        [Route("")] //Accessible at: /courses
        public IActionResult Index()
        {
            ViewBag.Title = "All Courses";
            return View();
        }

        [Route ("details/{id:int}")] //accessible at: /courses/details/5
        public IActionResult Details(int id)
        {
            ViewBag.CourseId = id;
            return View();
        }

        [Route("search")] //accessible at: /courses/search?keyword=mvc
        public IActionResult Search(string keyword)
        {
            ViewBag.Keyword = keyword;
            return View();
        }

    }
}

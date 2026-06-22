using Microsoft.AspNetCore.Mvc;

namespace F1stMVCApp.Controllers
{
    [Route("courses")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace F1stMVCApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string category, int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;
            return View();
        }
    }
}

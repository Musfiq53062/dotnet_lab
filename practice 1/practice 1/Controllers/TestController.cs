using Microsoft.AspNetCore.Mvc;

namespace practice_1.Controllers
{
    public class TestController : Controller
    {
        public ContentResult Hello()
        {
            return Content("Hello World");
        }

        public JsonResult GetJsonData()
        {
            var student = new { Id = 1, Name = "Musfiq" };
            return Json(student);
        }

        public RedirectResult GoToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        public RedirectToActionResult GoToHome()
        {
            return RedirectToAction("Index", "Home");
        }

        public FileResult Download()
        {
            var fileBytes = System.IO.File.ReadAllBytes(("wwwroot/StudentData.txt"));
            return File(fileBytes, "text/plain","Student.txt");
        }

        public ViewResult index()
        {
            return View(); 
        }
    } 
}

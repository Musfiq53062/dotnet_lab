using Microsoft.AspNetCore.Mvc;
using project2_Ums.Data;
using project2_Ums.Data.Entities;

namespace project2_Ums.Controllers
{
    public class FacultyController(UmsDbContext _context) : Controller
    {
        public IActionResult Index()
        {
            //IQueryable<Faculty> data = _context.Faculties;
            List<Faculty> data2 = _context.Faculties.ToList();
            return View(data2);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyLearningPortal.Controllers
{
    public class AdminController : Controller
    {
        // GET: /Admin
        public IActionResult Index()
        {
            return View(); // Maps to Views/Admin/Index.cshtml
        }

        // GET: /Admin/Courses
        public IActionResult Courses()
        {
            return View(); // Maps to Views/Admin/Courses.cshtml
        }

        // GET: /Admin/Users
        public IActionResult Users()
        {
            return View(); // Maps to Views/Admin/Users.cshtml
        }
    }
}

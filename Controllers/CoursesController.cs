using Microsoft.AspNetCore.Mvc;

public class CoursesController : Controller
{
    public IActionResult Index()
    {
        return View(); // Views/Courses/Index.cshtml
    }

    public IActionResult Create()
    {
        return View(); // Views/Courses/Create.cshtml
    }
}

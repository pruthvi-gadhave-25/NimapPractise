using Microsoft.AspNetCore.Mvc;

namespace ViewBagDEmo.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            List<string> courses = new List<string>();
            courses.Add(".net0");
            courses.Add(".net1");
            courses.Add(".net2");
            courses.Add(".net3");
            courses.Add(".net4");
            ViewData["Courses"] = courses;
            return View();
        
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
//Need to typecst in views 

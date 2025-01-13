using Microsoft.AspNetCore.Mvc;

namespace ViewBagDEmo.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult IndexTempData()
        {
            List<string> Courses = new List<string>();
            Courses.Add("J2SE");
            Courses.Add("J2EE");
            Courses.Add("Spring");
            Courses.Add("Hibernates");
            TempData["CoursesList"] = Courses;
            return View();
        }
    }
}

//value of tempdata persist only for one request to  next request
//// it requires  typescasting
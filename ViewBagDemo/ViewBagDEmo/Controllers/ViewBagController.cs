using Microsoft.AspNetCore.Mvc;

namespace ViewBagDEmo.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult IndexViewBag()
        {

            List<string> courses = new List<string>();
            courses.Add("J2SE");
            courses.Add("J2EE");
            courses.Add("Spring");
            courses.Add("Hibernates");
            ViewBag.Courses= courses;
            return View();
        }
    }
}

//ViewBAg no need to typecast 
// it is dynamic -> can get and set value dynamically 

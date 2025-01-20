using EcomMvc.Data;
using EcomMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomMvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("ListCategory");
            }
            else
            {
                return View(category);
            }
           
           
        }

        [HttpGet]
        public  IActionResult ListCategory()
        {
             var categories =  _context.Categories.ToList();
            if(categories.Count == 0 )
            {
                //TempData["Name"] = "Category";
                return View("NoData");
            }
            return View(categories);
        }
    }
}

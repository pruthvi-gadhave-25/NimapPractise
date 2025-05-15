using EcomMvc.Data;
using EcomMvc.Filters;
using EcomMvc.Models;
using EcomMvc.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EcomMvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICategoryRepositoy _categoryRepository;
        public CategoryController(AppDbContext appDbContext )
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AdminAuditLogFilter]
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
                //_context.Categories.Add(cat);
                _context.SaveChanges();
                return RedirectToAction("ListCategory");
            }
            else
            {
                return View(category);
            }
           
           
        }

        [HttpGet]
        //[AdminAuditLogFilter]
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


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Category? category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if(category == null)
            {
                return NotFound("Category is null");
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {


            if (category == null)
            {
                return NotFound("Id does not exists Or Product Not found");
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();
            //return Ok(" Category Deleted Succesfully");
            return RedirectToAction("ListCategory");


        }

        //Edit 
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var category = _context.Categories.FirstOrDefault(p => p.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public  IActionResult Edit(Category category)
        {
           Category existingCategory =  _context.Categories.FirstOrDefault(c => c.CategoryId==category.CategoryId);
            existingCategory.CategoryName = category.CategoryName;
           

            _context.SaveChangesAsync();
            return RedirectToAction("ListCategory");
        }


        //public async Task<IActionResult>  GetAllCategories()
        //{
        //  var res =  await  _categoryRepository.GetAllCategories();
        //    return res;
        //}
      

    }
}

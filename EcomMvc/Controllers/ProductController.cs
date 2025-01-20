using EcomMvc.Data;
using EcomMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcomMvc.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;
        public ProductController(AppDbContext appDbContext)
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
            
           var categories = _context.Categories.OrderBy(c => c.CategoryName).ToList();
            //TempData["Categories" ]= new SelectList(categories, "CategoryId", "CategoryName");
          ViewBag.Categories= new SelectList(categories, "CategoryId", "CategoryName");
            //TempData.Keep("Categories");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product productModel)
        {
            if (ModelState.IsValid)
            {               
                await  _context.Products.AddAsync(productModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListProducts");
            }

            else
            {
                //var categories = _context.Categories.OrderBy(c => c.CategoryName).ToList();
                //ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
                return View(productModel);
            }
             
        }


        [HttpGet]
        public IActionResult ListProducts()
        {
            var products = _context.Products.ToList();
            if (products.Count == null)
            {
                //TempData["Name"] = "Product";
                return RedirectToAction("NoData");
            }
            return View(products);
        }


    }
}

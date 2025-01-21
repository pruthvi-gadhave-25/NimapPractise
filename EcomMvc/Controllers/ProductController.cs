using EcomMvc.Data;
using EcomMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
          //  TempData["Categories" ]= new SelectList(categories, "CategoryId", "CategoryName");
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
                var categories = _context.Categories.OrderBy(c => c.CategoryName).ToList();
                ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
                return View(productModel);
            }
             
        }


        [HttpGet]
        public async Task<IActionResult> ListProducts()
        {
            List<Product> products =await  _context.Products.Include(c=> c.Category).ToListAsync();
          
            return View(products);
        }

        [HttpGet]
        public  IActionResult Delete(int id )
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
           
            return RedirectToAction("ListProducts");
        }


        //EDIT
        [HttpGet]
        public async  Task<IActionResult> Edit(int id)
        {

            var product = await _context.Products.Include(c => c.Category).FirstOrDefaultAsync(p => p.ProductId == id);
            ViewBag.Categories = new SelectList( _context.Categories, "CategoryId", "CategoryName");
           
            return View(product);
      
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product) 
        {
            if(!ModelState.IsValid){

                ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName");
                return View(product);

            }
            var category  =await  _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == product.CategoryId);
            product.Category=  category;
            var existingProduct =await _context.Products.FirstOrDefaultAsync(product => product.ProductId == product.ProductId);

            existingProduct.ProdcutName = product.ProdcutName;
            existingProduct.Category =product.Category;
            existingProduct.CategoryId =product.CategoryId;
            existingProduct.IsActive= product.IsActive;

            //_context.Products.Update(product);
            Console.WriteLine(existingProduct);
            _context.SaveChangesAsync();
          return RedirectToAction("ListProducts");
        }


    }
}

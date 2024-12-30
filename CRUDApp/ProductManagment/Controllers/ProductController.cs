using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagment.Models;
using ProductManagment.Data;

namespace ProductManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _appDbContext1;
        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext1 = appDbContext;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var allEmp = _appDbContext1.Products.ToList();
            return Ok(allEmp);
        }


        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetAllProducts(Guid id)
        {
            var product = _appDbContext1.Products.Find(id);
        
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(Product  product )
        {
           var res = _appDbContext1.Products.Add(product);
            _appDbContext1.SaveChanges();
            return Ok(res);
        }
        [HttpPut]
        [Route("{id:Guid}")]

        public IActionResult UpdateProduct(Guid id ,Product product)
        {
            var updatedProduct = _appDbContext1.Products.Find(id);
            _appDbContext1.SaveChanges();
            return Ok(updatedProduct);
           
        }
        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var product = _appDbContext1.Products.Find(id);
            if (product != null) {
                _appDbContext1.Products.Remove(product);
                _appDbContext1.SaveChanges();
            }
            else
            {
                Console.WriteLine("Prduct Not Found");
            }
           
            return Ok(product);

        }
    }
}

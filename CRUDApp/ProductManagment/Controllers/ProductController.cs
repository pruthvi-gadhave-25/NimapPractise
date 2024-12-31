using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagment.Models;
using ProductManagment.Data;
using ProductManagment.Services.Interface;

namespace ProductManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase    {
        //private readonly AppDbContext _appDbContext1;
            
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService  = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
                try
                {

                    if(_productService ==null)
                    {
                        return StatusCode(500,"Prodcut Sevcei Not Initialized");
                    }
                    var products = await _productService.GetAllProducts();

                    if (products == null)
                    {
                        return NotFound("Not Products Found");
                    }
                    return Ok(products);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest("Not Products Found");
                }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (product == null)
            {
                return BadRequest("Invalid product data.");
            }

            var result = await _productService.AddProduct(product);
            if (result)
            {
                return Ok("Product added successfully.");
            }
            return StatusCode(500, "An error occurred while adding the product.");


        }
         
        
        [HttpPut("{id}")]
            public async Task<IActionResult> UpdateProduct(Guid id,  Product product)
            {
                try
                {                  
                    var result = await _productService.UpdateProduct(product);
                    if (result)
                    {
                        return Ok("Product updated successfully.");
                    }
                return BadRequest("Not Updated");
               
            }
                catch (Exception ex)
                {
                    Console.WriteLine( ex.Message);
                    return StatusCode(500, "Error occurrs while updating the product");
                }
            }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            try
            {
                var result = await _productService.DeleteProduct(id);
                if (result)
                {
                    return Ok("Product deleted successfully.");
                }
                return StatusCode(500, "An error occurred while deleting the product.");
            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.Message);
                return BadRequest("Product Not Deleted");
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {

            var product = await _productService.GetProduct(id);


            return Ok(product);
        }
       
    }
}

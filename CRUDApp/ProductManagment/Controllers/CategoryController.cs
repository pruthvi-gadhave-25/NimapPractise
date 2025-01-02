using Microsoft.AspNetCore.Mvc;
using ProductManagment.Models;
using ProductManagment.Services.Interface;

namespace ProductManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    { 
        private readonly ICategoryService _categoryService;

        public CategoryController (ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _categoryService.GetCategory(id);
            if (category == null)
            {
                return NotFound("Category not found.");
            }
            return Ok(category);
        }


        [HttpPost]
        public async Task<IActionResult> AddCategory( Category category)
        {
            if (category == null)
            {
                return BadRequest("Invalid category data.");
            }

            var result = await _categoryService.AddCategory(category);
            if (result)
            {
                return Ok("Category added successfully.");
            }
            return StatusCode(500, "An error occurred while adding the category.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest("Category ID mismatch.");
            }

            var result = await _categoryService.UpdateCategory(category);
            if (result)
            {
                return Ok("Category updated successfully.");
            }
            return StatusCode(500, "An error occurred while updating the category.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await _categoryService.DeleteCategory(id);
            if (result)
            {
                return Ok("Category deleted successfully.");
            }
            return StatusCode(500, "An error occurred while deleting the category.");
        }

        [HttpPost("deactivate/{categoryId}")]
        public async Task<IActionResult> DeacivateCategory(int categoryId)
        {
            await _categoryService.DeactivateCategory(categoryId);

            return Ok("Deactivated Succesfully");
        }
      

        
    }
}

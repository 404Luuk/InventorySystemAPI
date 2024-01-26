using InventorySystemAPI.DataTransferObjects.CategoryDtos;
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystemAPI.Controllers;

[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IServiceManager _service;
    
    public CategoryController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("api/categories")]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _service.CategoryService.GetCategoriesAsync();
        return Ok(categories);
    }
    
    [HttpGet]
    [Route("api/categories/{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await _service.CategoryService.GetCategoryAsync(id);
        return Ok(category);
    }
    
    [HttpPost]
    [Route("api/categories")]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto category)
    {
        var categoryToReturn = await _service.CategoryService.CreateCategoryAsync(category);
        return Ok(categoryToReturn);
    }
    
    
    // [HttpPut]
    // [Route("api/categories/{id}")]
    // public async Task<IActionResult> UpdateCategory(Guid id, [FromBody] CategoryForUpdateDto category)
    // {
    //     var categoryToUpdate = await _service.CategoryService.GetCategoryAsync(id);
    //     if (categoryToUpdate == null)
    //     {
    //         return NotFound();
    //     }
    //     
    //     await _service.CategoryService.UpdateCategoryAsync(categoryToUpdate);
    //     return NoContent();
    // }
    
    [HttpDelete]
    [Route("api/categories/{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var category = await _service.CategoryService.GetCategoryAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        
        await _service.CategoryService.DeleteCategoryAsync(id);
        return NoContent();
    }
}
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystemAPI.Controllers;

[ApiController]
public class ItemController : ControllerBase
{
    private readonly IServiceManager _service;
    
    public ItemController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("api/items")]
    public async Task<IActionResult> GetItems()
    {
        var items = await _service.ItemService.GetItemsAsync();
        return Ok(items);
    }
    
    [HttpGet]
    [Route("api/items/{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        var item = await _service.ItemService.GetItemAsync(id);
        return Ok(item);
    }
    
    [HttpPost]
    [Route("api/items")]
    public async Task<IActionResult> CreateItem([FromBody] ItemForCreationDto item)
    {
        var itemToReturn = await _service.ItemService.CreateItemAsync(item);
        return Ok(itemToReturn);
    }
    
    
    // [HttpPut]
    // [Route("api/items/{id}")]
    // public async Task<IActionResult> UpdateItem(Guid id, [FromBody] ItemForUpdateDto item)
    // {
    //     var itemToUpdate = await _service.ItemService.GetItemAsync(id);
    //     if (itemToUpdate == null)
    //     {
    //         return NotFound();
    //     }
    //     
    //     await _service.ItemService.UpdateItemAsync(itemToUpdate);
    //     return NoContent();
    // }
    
    [HttpDelete]
    [Route("api/items/{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        var item = await _service.ItemService.GetItemAsync(id);
        if (item == null)
        {
            return NotFound();
        }
        
        await _service.ItemService.DeleteItemAsync(id);
        return NoContent();
    }
}
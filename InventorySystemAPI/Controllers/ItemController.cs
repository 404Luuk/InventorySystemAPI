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
    public async Task<IActionResult> GetItemById(Guid id)
    {
        var item = await _service.ItemService.GetItemAsync(id);
        return Ok(item);
    }
}
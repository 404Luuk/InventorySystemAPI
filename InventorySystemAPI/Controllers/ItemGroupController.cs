using InventorySystemAPI.DataTransferObjects.ItemGroupDtos;
using InventorySystemAPI.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystemAPI.Controllers;

[ApiController]
public class ItemGroupController :ControllerBase
{
    private readonly IServiceManager _service;
    
    public ItemGroupController(IServiceManager serivce)
    {
        _service = _service;
    }
    
    [HttpGet]
    [Route("api/itemgroups")]
    public async Task<IActionResult> GetItemGroups()
    {
        var itemGroups = await _service.ItemGroupService.GetItemGroupsAsync();
        return Ok(itemGroups);
    }
    
    [HttpGet]
    [Route("api/itemgroups/{id}")]
    public async Task<IActionResult> GetItemGroupById(int id)
    {
        var itemGroup = await _service.ItemGroupService.GetItemGroupAsync(id);
        return Ok(itemGroup);
    }
    
    [HttpPost]
    [Route("api/itemgroups")]
    public async Task<IActionResult> CreateItemGroup([FromBody] ItemGroupForCreationDto itemGroup)
    {
        var itemGroupToReturn = await _service.ItemGroupService.CreateItemGroupAsync(itemGroup);
        return Ok(itemGroupToReturn);
    }
    
    // [HttpPut]
    // [Route("api/itemgroups/{id}")]
    // public async Task<IActionResult> UpdateItemGroup(Guid id, [FromBody] ItemGroupForUpdateDto itemGroup)
    // {
    //     var itemGroupToUpdate = await _service.ItemGroupService.GetItemGroupAsync(id);
    //     if (itemGroupToUpdate == null)
    //     {
    //         return NotFound();
    //     }
    //
    //     await _service.ItemGroupService.UpdateItemGroupAsync(itemGroupToUpdate);
    //     return NoContent();
    // }
    
    [HttpDelete]
    [Route("api/itemgroups/{id}")]
    public async Task<IActionResult> DeleteItemGroup(int id)
    {
        var itemGroup = await _service.ItemGroupService.GetItemGroupAsync(id);
        if (itemGroup == null)
        {
            return NotFound();
        }

        await _service.ItemGroupService.DeleteItemGroupAsync(id);
        return NoContent();
    }
}
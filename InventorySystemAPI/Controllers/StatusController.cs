using InventorySystemAPI.DataTransferObjects.StatusDtos;
using InventorySystemAPI.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystemAPI.Controllers;

[ApiController]
public class StatusController : ControllerBase
{
    private readonly IServiceManager _service;
    
    public StatusController(IServiceManager service)
    {
        _service = service;
    }
    
    [HttpPost]
    [Route("api/status")]
    public async Task<IActionResult> CreateStatus([FromBody] StatusForCreationDto status)
    {
        var statusToReturn = await _service.StatusService.CreateStatusAsync(status);
        return Ok(statusToReturn);
    }
    
    [HttpGet]
    [Route("api/status/{id}")]
    public async Task<IActionResult> GetStatusById(int id)
    {
        var status = await _service.StatusService.GetStatusAsync(id);
        return Ok(status);
    }
    
    [HttpGet]
    [Route("api/status")]
    public async Task<IActionResult> GetStatuses()
    {
        var statuses = await _service.StatusService.GetStatusesAsync();
        return Ok(statuses);
    }
    
    // [HttpPut]
    // [Route("api/status/{id}")]
    // public async Task<IActionResult> UpdateStatus(int id, [FromBody] StatusForUpdateDto status)
    // {
    //     var statusToUpdate = await _service.StatusService.GetStatusAsync(id);
    //     if (statusToUpdate == null)
    //     {
    //         return NotFound();
    //     }
    //     
    //     await _service.StatusService.UpdateStatusAsync(statusToUpdate);
    //     return NoContent();
    // }
    
    
    [HttpDelete]
    [Route("api/status/{id}")]
    public async Task<IActionResult> DeleteStatus(int id)
    {
        var status = await _service.StatusService.GetStatusAsync(id);
        if (status == null)
        {
            return NotFound();
        }
        
        await _service.StatusService.DeleteStatusAsync(id);
        return NoContent();
    }
}
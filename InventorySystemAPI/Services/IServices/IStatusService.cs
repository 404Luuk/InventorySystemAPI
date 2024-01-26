using InventorySystemAPI.DataTransferObjects.StatusDtos;

namespace InventorySystemAPI.Services.IServices;

public interface IStatusService
{  
    Task<StatusDto> GetStatusAsync(int id);
    Task<IEnumerable<StatusDto>> GetStatusesAsync();
    Task<StatusDto> CreateStatusAsync(StatusForCreationDto status);
    Task<StatusDto> UpdateStatusAsync(StatusDto status); // change to StatusForUpdateDto when implemented
    Task DeleteStatusAsync(int id);
}
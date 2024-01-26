using InventorySystemAPI.DataTransferObjects.ItemGroupDtos;

namespace InventorySystemAPI.Services.IServices;

public interface IItemGroupService
{
    Task<ItemGroupDto> GetItemGroupAsync(int id);
    Task<IEnumerable<ItemGroupDto>> GetItemGroupsAsync();
    Task<ItemGroupDto> CreateItemGroupAsync(ItemGroupForCreationDto itemGroup);
    Task<ItemGroupDto> UpdateItemGroupAsync(ItemGroupDto itemGroup); // change to ItemGroupForUpdateDto when implemented
    Task DeleteItemGroupAsync(int id);
}
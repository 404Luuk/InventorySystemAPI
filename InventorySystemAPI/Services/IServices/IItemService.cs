using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Services.IServices;

public interface IItemService
{
    Task<ItemDto> GetItemAsync(int id);
    Task<IEnumerable<ItemDto>> GetItemsAsync();
    Task<ItemDto> CreateItemAsync(ItemForCreationDto item);
    Task<Item> UpdateItemAsync(ItemDto item); // change to ItemForUpdateDto when implemented
    Task DeleteItemAsync(int id);
    
}
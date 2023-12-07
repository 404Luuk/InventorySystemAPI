using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.Entities;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ItemService : IItemService
{
    public Task<ItemDto> GetItemAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ItemDto>> GetItemsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ItemDto> CreateItemAsync(ItemForCreationDto item)
    {
        throw new NotImplementedException();
    }

    public Task<Item> UpdateItemAsync(Item item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteItemAsync(int id)
    {
        throw new NotImplementedException();
    }
}
using AutoMapper;
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ItemService : IItemService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    
    public ItemService(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<ItemDto> GetItemAsync(int id)
    {
        var item = await _repository.ItemRepository.GetItemAsync(id, false);

        var itemToReturn = _mapper.Map<ItemDto>(item);

        return itemToReturn;
    }

    public async Task<IEnumerable<ItemDto>> GetItemsAsync()
    {
        var items = await _repository.ItemRepository.GetItemsAsync();
        var itemsToReturn = _mapper.Map<IEnumerable<ItemDto>>(items);

        return itemsToReturn;
    }

    public async Task<ItemDto> CreateItemAsync(ItemForCreationDto item)
    {
        var itemEntity = _mapper.Map<Item>(item);
        
        _repository.ItemRepository.CreateItem(itemEntity);
        await _repository.SaveAsync();
        
        var itemToReturn = _mapper.Map<ItemDto>(itemEntity);
        
        return itemToReturn;
    }

    public Task<Item> UpdateItemAsync(ItemDto item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteItemAsync(int id)
    {   
        throw new NotImplementedException();
    }
}
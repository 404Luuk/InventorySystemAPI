using AutoMapper;
using InventorySystemAPI.DataTransferObjects.ItemGroupDtos;
using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ItemGroupService : IItemGroupService
{  
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    
    public ItemGroupService(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<ItemGroupDto> GetItemGroupAsync(int id)
    {
        var itemGroup = await _repository.ItemGroupRepository.GetItemGroupAsync(id, false);

        var itemGroupToReturn = _mapper.Map<ItemGroupDto>(itemGroup);

        return itemGroupToReturn;
    }
    
    public async Task<IEnumerable<ItemGroupDto>> GetItemGroupsAsync()
    {
        var itemGroups = await _repository.ItemGroupRepository.GetItemGroupsAsync();
        var itemGroupsToReturn = _mapper.Map<IEnumerable<ItemGroupDto>>(itemGroups);

        return itemGroupsToReturn;
    }
    
    public async Task<ItemGroupDto> CreateItemGroupAsync(ItemGroupForCreationDto itemGroup)
    {
        var itemGroupEntity = _mapper.Map<ItemGroup>(itemGroup);
        
        _repository.ItemGroupRepository.CreateItemGroup(itemGroupEntity);
        await _repository.SaveAsync();
        
        var itemGroupToReturn = _mapper.Map<ItemGroupDto>(itemGroupEntity);
        
        return itemGroupToReturn;
    }
    
    public async Task<ItemGroupDto> UpdateItemGroupAsync(ItemGroupDto itemGroup)
    {
        throw new NotImplementedException();
    }
    
    public async Task DeleteItemGroupAsync(int id)
    {   
        throw new NotImplementedException();
    }
}
using AutoMapper;
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.DataTransferObjects.StatusDtos;
using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Item, ItemDto>();
        CreateMap<ItemForCreationDto, Item>();
        // CreateMap<ItemForUpdateDto, Item>();
        
        CreateMap<Status, StatusDto>();
        CreateMap<StatusForCreationDto, Status>();
    }
}
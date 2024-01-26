using AutoMapper;
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.DataTransferObjects.ItemGroupDtos;
using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Item, ItemDto>();
        CreateMap<ItemForCreationDto, Item>();
        // CreateMap<ItemForUpdateDto, Item>();
        
        CreateMap<ItemGroup, ItemGroupDto>();
        CreateMap<ItemGroupForCreationDto, ItemGroup>();
        // CreateMap<ItemGroupForUpdateDto, ItemGroup>();
    }
}
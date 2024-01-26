using AutoMapper;
using InventorySystemAPI.DataTransferObjects.CategoryDtos;
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.DataTransferObjects.StatusDtos;
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
        
        CreateMap<Status, StatusDto>();
        CreateMap<StatusForCreationDto, Status>();

        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryForCreationDto, Category>();
        // CreateMap<CategoryForUpdateDto, Category>();
        
        CreateMap<ItemGroup, ItemGroupDto>();
        CreateMap<ItemGroupForCreationDto, ItemGroup>();
        // CreateMap<ItemGroupForUpdateDto, ItemGroup>();
    }
}
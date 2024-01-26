using AutoMapper;
using InventorySystemAPI.DataTransferObjects.CategoryDtos;
using InventorySystemAPI.DataTransferObjects.ItemDTOs;
using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Item, ItemDto>();
        CreateMap<ItemForCreationDto, Item>();
        // CreateMap<ItemForUpdateDto, Item>();

        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryForCreationDto, Category>();
        // CreateMap<CategoryForUpdateDto, Category>();
    }
}
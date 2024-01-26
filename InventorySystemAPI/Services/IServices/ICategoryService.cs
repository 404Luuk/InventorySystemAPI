using InventorySystemAPI.DataTransferObjects.CategoryDtos;

namespace InventorySystemAPI.Services.IServices;

public interface ICategoryService
{
    Task<CategoryDto> GetCategoryAsync(int id);
    Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
    Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category);
    Task<CategoryDto> UpdateCategoryAsync(CategoryDto category); // change to CategoryForUpdateDto when implemented
    Task DeleteCategoryAsync(int id);
}
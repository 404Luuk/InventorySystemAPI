using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Repositories.IRepositories;

public interface ICategoryRepository
{
    void CreateCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
    Task<Category> GetCategoryAsync(int categoryId, bool trackChanges);
    Task<IEnumerable<Category>> GetCategoriesAsync();
}
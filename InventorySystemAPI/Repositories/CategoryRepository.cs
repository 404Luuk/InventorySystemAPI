using InventorySystemAPI.Entities;
using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Repositories;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
    
    public void CreateCategory(Category category)
    { 
        Create(category);
    }

    public void UpdateCategory(Category category)
    {
        Update(category);
    }

    public void DeleteCategory(Category category)
    {
        Delete(category);
    }

    public async Task<Category> GetCategoryAsync(int categoryId, bool trackChanges = false)
        => await FindByCondition(o => o.Id.Equals(categoryId), trackChanges).FirstOrDefaultAsync() ?? throw new InvalidOperationException();

    public Task<IEnumerable<Category>> GetCategoriesAsync()
    {
        var items = FindAll(trackChanges: false);
        
        return Task.FromResult(items.AsEnumerable());
    }


}
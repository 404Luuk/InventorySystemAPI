using AutoMapper;
using InventorySystemAPI.DataTransferObjects.CategoryDtos;
using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class CategoryService : ICategoryService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    
    public CategoryService(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<CategoryDto> GetCategoryAsync(int id)
    {
        var category = await _repository.CategoryRepository.GetCategoryAsync(id, false);

        var categoryToReturn = _mapper.Map<CategoryDto>(category);

        return categoryToReturn;
    }
    
    public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
    {
        var categories = await _repository.CategoryRepository.GetCategoriesAsync();
        var categoriesToReturn = _mapper.Map<IEnumerable<CategoryDto>>(categories);

        return categoriesToReturn;
    }
    
    public async Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category)
    {
        var categoryEntity = _mapper.Map<Category>(category);
        
        _repository.CategoryRepository.CreateCategory(categoryEntity);
        await _repository.SaveAsync();
        
        var categoryToReturn = _mapper.Map<CategoryDto>(categoryEntity);
        
        return categoryToReturn;
    }
    
    public async Task<CategoryDto> UpdateCategoryAsync(CategoryDto category)
    {
        throw new NotImplementedException();
    }
    
    public async Task DeleteCategoryAsync(int id)
    {   
        throw new NotImplementedException();
    }
}
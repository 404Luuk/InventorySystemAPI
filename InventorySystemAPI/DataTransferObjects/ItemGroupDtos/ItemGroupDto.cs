using InventorySystemAPI.DataTransferObjects.CategoryDtos;

namespace InventorySystemAPI.DataTransferObjects.ItemGroupDtos;

public class ItemGroupDto
{
    public int Id { get; set; }
    public string? ItemGroupName { get; set; }
    public string? Description { get; set; }
    public int ItemStock { get; set; }
    
    // Foreign key properties
    public CategoryDto Category { get; set; }
}
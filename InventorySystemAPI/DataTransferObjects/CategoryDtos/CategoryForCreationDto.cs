using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.DataTransferObjects.CategoryDtos;

public class CategoryForCreationDto
{
    [Required(ErrorMessage = "Category name is required")]
    public string CategoryName { get; set; }
}
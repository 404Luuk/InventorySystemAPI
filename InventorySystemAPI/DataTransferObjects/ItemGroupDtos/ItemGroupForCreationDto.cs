using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.DataTransferObjects.ItemGroupDtos;

public class ItemGroupForCreationDto
{
    [Required(ErrorMessage = "Group name is required")]
    public string? ItemGroupName { get; set; }
    [Required(ErrorMessage = "A stock of at least 0 is required")]
    public int ItemStock { get; set; }
    
    // Foreign key properties
    [Required(ErrorMessage = "Category is required")]
    public int CategoryId { get; set; }
}
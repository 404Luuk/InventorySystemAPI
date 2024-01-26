using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.DataTransferObjects.ItemDTOs;

public class ItemForCreationDto
{
    [Required(ErrorMessage = "Name is required")]
    public string? ItemName { get; set; }
    [Required(ErrorMessage = "Availability status is required")]
    public bool Availability { get; set; }
    public string? ItemNotes { get; set; }
    public string? ItemImage { get; set; }

    // Foreign key properties
    [Required(ErrorMessage = "Status is required")]
    public int StatusId { get; set; }
}
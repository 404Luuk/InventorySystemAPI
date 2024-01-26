using System.ComponentModel.DataAnnotations;
using InventorySystemAPI.Enums;

namespace InventorySystemAPI.DataTransferObjects.ItemDTOs;

public class ItemForCreationDto
{
    [Required(ErrorMessage = "Name is required")]
    public string? ItemName { get; set; }
    [Required(ErrorMessage = "Availability status is required")]
    public Availability? Availability { get; set; }
    public string? ItemNotes { get; set; }
    public string? ItemImage { get; set; }

}
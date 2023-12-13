using System.ComponentModel.DataAnnotations;
using InventorySystemAPI.Enums;

namespace InventorySystemAPI.DataTransferObjects.ItemDTOs;

public class ItemForCreationDto
{
    [Required(ErrorMessage = "Name is required")]
    public string? ItemName { get; set; }
    [Required(ErrorMessage = "Item must have availability status")]
    public Availability? Availability { get; set; }
    public string? ItemOwner { get; set; }
    public string? ItemCurrentHolder { get; set; }

}
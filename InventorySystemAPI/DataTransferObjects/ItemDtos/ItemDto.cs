using InventorySystemAPI.DataTransferObjects.ItemGroupDtos;
using InventorySystemAPI.DataTransferObjects.StatusDtos;

namespace InventorySystemAPI.DataTransferObjects.ItemDTOs;

public class ItemDto
{
    public int Id { get; set; }
    public string? ItemName { get; set; }
    public bool ItemAvailability { get; set; }
    public string? ItemNotes { get; set; }
    public string? ItemImage { get; set; }
    
    // Foreign key properties
    public StatusDto? Status { get; set; }
    public ItemGroupDto? ItemGroup { get; set; }
}
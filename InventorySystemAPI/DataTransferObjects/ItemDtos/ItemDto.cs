using InventorySystemAPI.Enums;

namespace InventorySystemAPI.DataTransferObjects.ItemDTOs;

public class ItemDto
{
    public int Id { get; set; }
    public string? ItemName { get; set; }
    public Availability? ItemAvailability { get; set; }
    public string? ItemOwner { get; set; }
    public string? ItemCurrentHolder { get; set; }
}
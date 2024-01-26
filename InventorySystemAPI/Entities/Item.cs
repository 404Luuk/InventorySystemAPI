using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.Entities;

public class Item
{
    [Key]
    public int Id { get; set; }
    [MaxLength(30, ErrorMessage = "Maximum length may not exceed 30 chars")]
    public string? ItemName { get; set; }
    public bool ItemAvailability { get; set; }
    public string? ItemNotes { get; set; }
    public string? ItemImage { get; set; }
    
    // Foreign key properties
    public int StatusId { get; set; }
}
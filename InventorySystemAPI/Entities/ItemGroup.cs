using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.Entities;

public class ItemGroup
{
    public Category Category { get; set; }

    [Key]
    public int Id { get; set; }
    [MaxLength(30, ErrorMessage = "Maximum length may not exceed 30 chars")]
    public string? ItemGroupName { get; set; }
    public string? Description { get; set; }
    public int ItemStock { get; set; }
    
    // Foreign key properties
    public int CategoryId { get; set; }
}
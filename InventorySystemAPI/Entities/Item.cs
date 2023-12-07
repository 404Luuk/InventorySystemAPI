using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.Entities;

public enum Availability
{
    AVAILABLE,
    UNAVAILABLE,
    BROKEN,
    MISSING
}

public class Item
{
    public int Id { get; set; }
    [MaxLength(30, ErrorMessage = "Maximum length may not exceed 30 chars")]
    public string? ItemName { get; set; }
    public Availability ItemAvailability { get; set; }
    public string? ItemOwner { get; set; } //  possibly change to user object when implemented
    public string? ItemCurrentHolder { get; set; } //name is tacky
}
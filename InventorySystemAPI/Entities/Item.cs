using System.ComponentModel.DataAnnotations;
using InventorySystemAPI.Enums;

namespace InventorySystemAPI.Entities;

public class Item
{
    public Guid Id { get; set; }
    [MaxLength(30, ErrorMessage = "Maximum length may not exceed 30 chars")]
    public string? ItemName { get; set; }
    public Availability ItemAvailability { get; set; }
    public string? ItemOwner { get; set; } //  possibly change to user object when implemented
    public string? ItemCurrentHolder { get; set; } //name is tacky
}
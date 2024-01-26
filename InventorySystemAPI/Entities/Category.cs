using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    [MaxLength(30, ErrorMessage = "Maximum length may not exceed 30 chars")]
    public string CategoryName { get; set; }
}
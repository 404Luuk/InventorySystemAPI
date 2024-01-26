using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.DataTransferObjects.StatusDtos;

public class StatusForCreationDto
{
    [Required(ErrorMessage = "Status name is required")]
    public string? StatusName { get; set; }
}
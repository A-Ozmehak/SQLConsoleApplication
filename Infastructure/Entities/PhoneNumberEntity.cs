using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class PhoneNumberEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string PhoneNumber { get; set; } = null!;
}

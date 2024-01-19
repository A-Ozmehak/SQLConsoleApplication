using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class AddressEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Address { get; set; } = null!;

    [Required]
    public string? PostalCode { get; set; } = null!;

    [Required]
    public string? City { get; set; } = null!;
}

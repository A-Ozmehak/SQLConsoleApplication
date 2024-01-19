using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class ContactEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(AddressEntity))]
    public int AddressId { get; set; }

    public virtual AddressEntity Address { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(PhoneNumberEntity))]
    public int PhoneNumberId { get; set; }

    public virtual PhoneNumberEntity PhoneNumber { get; set; } = null!;
}

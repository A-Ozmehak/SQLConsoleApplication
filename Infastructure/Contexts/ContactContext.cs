using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class ContactContext(DbContextOptions<ContactContext> options) :DbContext(options)
{

    public virtual DbSet<ContactEntity> Contacts { get; set; }
    public virtual DbSet<AddressEntity> Addresses { get; set; }
    public virtual DbSet<PhoneNumberEntity> PhoneNumbers { get; set; }
}

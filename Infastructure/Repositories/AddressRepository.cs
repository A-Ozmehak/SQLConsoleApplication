using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class AddressRepository : Repository<AddressEntity, ContactContext>, IAddressRepository
{
    private readonly ContactContext _context;
    public AddressRepository(ContactContext context) : base(context)
    {
        _context = context;
    }
}

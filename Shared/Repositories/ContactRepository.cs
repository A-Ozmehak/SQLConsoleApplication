using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Shared.Context;
using Shared.Entities;
using Shared.Interfaces;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Shared.Repositories;

public class ContactRepository(ContactContext context) : BaseRepository<ContactEntity>(context)
{
    private readonly ContactContext _context = context;

    //public override int Create(ContactEntity entity)
    //{
    //    try
    //    {
            
    //    }
    //    catch (Exception ex) { Debug.WriteLine(ex.Message); }
    //}

    public override IEnumerable<ContactEntity> GetAll()
    {
        try
        {
            return _context.Contacts.Include(x => x.AddressId).ToList();
        }
        catch(Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public override ContactEntity GetOne(Expression<Func<ContactEntity, bool>> predicate)
    {
       try
        {
            return _context.Contacts.Include(x => x.Email).FirstOrDefault(predicate, null!);
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public void Update(ContactEntity entity)
    {
       
    }

    public void Delete (int id)
    {
       
        
    }
}

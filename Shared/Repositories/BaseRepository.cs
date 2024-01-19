using Microsoft.EntityFrameworkCore.Update.Internal;
using Shared.Context;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Shared.Repositories;

public abstract class BaseRepository<TEntity> where TEntity : class
{
    private readonly ContactContext _context;

    protected BaseRepository(ContactContext context)
    {
        _context = context;
    }

    public virtual TEntity Create(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        try
        {
            var result = _context.Set<TEntity>().ToList();
            if (result != null)
                return result;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual TEntity GetOne(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            var result = _context.Set<TEntity>().FirstOrDefault(predicate);
            if (result != null)
                return result;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual TEntity Update(TEntity entity)
    {
        try
        {
            var updateEntity = _context.Set<TEntity>().Find(entity);
            if (updateEntity != null)
            {
                updateEntity = entity;
                _context.Set<TEntity>().Update(updateEntity);
                _context.SaveChanges();

                return updateEntity;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual bool Delete(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(predicate);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();

                return true;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}

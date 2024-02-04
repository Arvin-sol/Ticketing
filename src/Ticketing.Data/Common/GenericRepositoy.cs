using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.Common;
public class GenericRepositoy<TEntity> where TEntity : class, IEntity
{
    protected readonly ApplicationDbContext _context;
    public GenericRepositoy(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity?> GetByIdAsync(Guid id) => await _context.Set<TEntity>().FindAsync(id);
    
    public async Task<bool> CreateAsync(TEntity entity)
    {
        var resualt = await _context.Set<TEntity>().AddAsync(entity);
        if (resualt.State == EntityState.Added)
        {
            return true;
        }
        return false;
    }
    public async Task<ICollection<TEntity>> GetAllAsync() => await _context.Set<TEntity>().ToListAsync();
    public bool Delete(TEntity model)
    {
        var resualt = _context.Remove(model);
        if (resualt.State == EntityState.Deleted)
        {
            return true;
        }
        return false;
    }
    public bool Update(TEntity model)
    {
        var resualt = _context.Update(model);
        if (resualt.State == EntityState.Modified)
        {
            return true;
        }
        return false;
    }
}


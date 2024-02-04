using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.Common;
using Ticketing.Data.Interfaces;

namespace Ticketing.Data.Implementations;
public class ApplicationUnitOfWork(ApplicationDbContext dbContext) : IApplicationUnitOfWork
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await _dbContext.DisposeAsync();
    }

    public bool SaveChanges()
    {
        return _dbContext.SaveChanges() > 0;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync() > 0;
    }
}


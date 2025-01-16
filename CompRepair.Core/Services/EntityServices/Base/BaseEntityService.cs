using CompRepair.Core.Database;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices.Base;

public class BaseEntityService<TEntity> where TEntity : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;
    
    public BaseEntityService()
    {
        _context = new AppDbContext();
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        try
        {
            await _context.Database.BeginTransactionAsync();
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            _dbSet.Remove(entity);
            var result = await _context.SaveChangesAsync();
            
            await _context.Database.CommitTransactionAsync();
            
            return result > 0;
        }
        catch (Exception e)
        {
            await _context.Database.RollbackTransactionAsync();
            throw;
        }
    }
}
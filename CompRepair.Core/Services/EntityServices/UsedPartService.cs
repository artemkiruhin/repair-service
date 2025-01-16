using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices;

public class UsedPartService : BaseEntityService<UsedPartEntity>
{
    public async Task<List<UsedPartDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(x =>
            new UsedPartDto(
                x.Id,
                x.Quantity,
                x.PricePerUnit,
                x.PartId,
                x.Part.Name,
                x.RepairOrderId
            )).ToList();
        return dtos;
    }

    public async Task<UsedPartDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new UsedPartDto(
            entity.Id,
            entity.Quantity,
            entity.PricePerUnit,
            entity.PartId,
            entity.Part.Name,
            entity.RepairOrderId
            );
        return dto;
    }

    public async Task<bool> AddAsync(Guid partId, int quantity, decimal pricePerUnit, Guid repairOrderId)
    {
        try
        {
            var entity = UsedPartEntity.Create(partId, quantity, pricePerUnit, repairOrderId);
            await _context.Database.BeginTransactionAsync();

            await _dbSet.AddAsync(entity);
            var result = await _context.SaveChangesAsync() > 0;
            await _context.Database.CommitTransactionAsync();

            return result;
        }
        catch (Exception e)
        {
            await _context.Database.RollbackTransactionAsync();
            throw;
        }
    }
    
    public async Task<bool> UpdateAsync(Guid id, int? quantity, decimal? pricePerUnit, Guid? repairOrderId)
    {
        try
        {
            if (!quantity.HasValue && !pricePerUnit.HasValue && !repairOrderId.HasValue) throw new NullReferenceException();
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            
            await _context.Database.BeginTransactionAsync();
           
            if(quantity.HasValue) entity.Quantity = quantity.Value;
            if(pricePerUnit.HasValue) entity.PricePerUnit = pricePerUnit.Value;
            if(repairOrderId.HasValue) entity.RepairOrderId = repairOrderId.Value;
            
            _dbSet.Update(entity);
            var result = await _context.SaveChangesAsync() > 0; 
            await _context.Database.CommitTransactionAsync();
            
            return result;
        }
        catch (Exception e)
        {
            await _context.Database.RollbackTransactionAsync();
            throw;
        }
    }
}
using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices;

public class PartService : BaseEntityService<PartEntity>
{
    public async Task<List<PartDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(x =>
            new PartDto(
                x.Id,
                x.Name,
                x.Description ?? "",
                x.Price,
                x.StockQuantity,
                x.Category.Name,
                x.Manufacturer.Name,
                x.UsedParts.Select(u =>
                    new UsedPartDto(
                        u.Id,
                        u.Quantity,
                        u.PricePerUnit,
                        u.PartId,
                        u.Part.Name,
                        u.RepairOrderId
                    )
                ).ToList()
            )).ToList();
        return dtos;
    }

    public async Task<PartDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new PartDto(
            entity.Id,
            entity.Name,
            entity.Description ?? "",
            entity.Price,
            entity.StockQuantity,
            entity.Category.Name,
            entity.Manufacturer.Name,
            entity.UsedParts.Select(u =>
                new UsedPartDto(
                    u.Id,
                    u.Quantity,
                    u.PricePerUnit,
                    u.PartId,
                    u.Part.Name,
                    u.RepairOrderId
                )
            ).ToList()
        );
        return dto;
    }

    public async Task<bool> AddAsync(string name, string description, decimal price, int stockQuantity, Guid categoryId, Guid manufacturerid)
    {
        try
        {
            var entity = PartEntity.Create(name, description, price, stockQuantity, categoryId, manufacturerid);
            if (entity == null) throw new KeyNotFoundException();
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
    
    public async Task<bool> UpdateAsync(Guid id, string? name, string? description, decimal? price, int? stockQuantity, Guid? categoryId, Guid? manufacturerId)
    {
        try
        {
            if (name == null && description == null && !categoryId.HasValue && !manufacturerId.HasValue && !stockQuantity.HasValue && !price.HasValue) throw new NullReferenceException(); 
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            await _context.Database.BeginTransactionAsync();

            if (name != null) entity.Name = name;
            if (description != null) entity.Description = description;
            if (categoryId.HasValue) entity.CategoryId = categoryId.Value;
            if (manufacturerId.HasValue) entity.ManufacturerId = manufacturerId.Value;
            if (stockQuantity.HasValue) entity.StockQuantity = stockQuantity.Value;
            if (price.HasValue) entity.Price = price.Value;
            
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
}
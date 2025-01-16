﻿using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices;

public class ManufacturerService : BaseEntityService<ManufacturerEntity>
{
    public async Task<List<ManufacturerDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(x => new ManufacturerDto(x.Id, x.Name)).ToList();
        return dtos;
    }

    public async Task<ManufacturerDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new ManufacturerDto(entity.Id, entity.Name);
        return dto;
    }

    public async Task<bool> AddAsync(string name)
    {
        try
        {
            var entity = ManufacturerEntity.Create(name);
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
    
    public async Task<bool> UpdateAsync(Guid id, string name)
    {
        try
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            
            await _context.Database.BeginTransactionAsync();
           
            entity.Name = name;
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
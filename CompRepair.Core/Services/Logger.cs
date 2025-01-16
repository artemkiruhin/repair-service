using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services;

public class Logger : BaseEntityService<LogEntity>
{
    public async Task<bool> Info(string message, Guid? userId) => await AddAsync(userId, message);
    public async Task<bool> Warn(string message, Guid? userId) => await AddAsync(userId, message, LogType.Warn);
    public async Task<bool> Error(string message, Guid? userId) => await AddAsync(userId, message, LogType.Error);
    
    public async Task<List<LogDto>> GetByTypeAsync(LogType type)
    {
        var logTypeStr = type switch
        {
            LogType.Info => "Info",
            LogType.Error => "Error",
            LogType.Warn => "Debug",
            _ => throw new NullReferenceException()
        };
        var entities = await _dbSet.AsNoTracking().Where(x => x.LogType == logTypeStr).ToListAsync();
        var dtos = entities.Select(x => new LogDto(
            x.Id,
            x.CreatedAt,
            x.UserId,
            x.Message,
            x.LogType
        )).ToList();
        return dtos;
    }

    public async Task<List<LogDto>> GetByUserAsync(Guid userId)
    {
        var entities = await _dbSet.AsNoTracking().Where(x => x.UserId == userId).ToListAsync();
        var dtos = entities.Select(x => new LogDto(
            x.Id,
            x.CreatedAt,
            x.UserId,
            x.Message,
            x.LogType
        )).ToList();
        return dtos;
    }
    
    public async Task<List<LogDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(x => new LogDto(
            x.Id,
            x.CreatedAt,
            x.UserId,
            x.Message,
            x.LogType
            )).ToList();
        return dtos;
    }

    public async Task<LogDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new LogDto(
            entity.Id,
            entity.CreatedAt,
            entity.UserId,
            entity.Message,
            entity.LogType
        );
        return dto;
    }

    public async Task<bool> AddAsync(Guid? userId, string message, LogType logType = LogType.Info)
    {
        try
        {
            var logTypeStr = logType switch
            {
                LogType.Info => "Info",
                LogType.Error => "Error",
                LogType.Warn => "Debug",
                _ => throw new NullReferenceException()
            };
            
            var entity = LogEntity.Create(DateTime.UtcNow, userId, message, logTypeStr);
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
    
    public async Task<bool> UpdateAsync(Guid id, Guid? userId, string? message, LogType? logType)
    {
        try
        {
            if (!userId.HasValue && string.IsNullOrEmpty(message) && !logType.HasValue)
            {
                throw new NullReferenceException();
            }
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            
            await _context.Database.BeginTransactionAsync();
            
            if (userId.HasValue) entity.UserId = userId.Value;
            if (!string.IsNullOrEmpty(message)) entity.Message = message;
            if (logType.HasValue)
            {
                var logTypeStr = logType switch
                {
                    LogType.Info => "Info",
                    LogType.Error => "Error",
                    LogType.Warn => "Debug",
                    _ => throw new NullReferenceException()
                };
                entity.LogType = logTypeStr;
            }
           
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
using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices;

public class RepairOrderService : BaseEntityService<RepairOrderEntity>
{
    public async Task<List<RepairOrderDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(order =>
            new RepairOrderDto(
                order.SerialNumber,
                order.Client.FullName,
                order.Client.Phone,
                order.Client.Email ?? "",
                order.TechnicianId,
                order.Technician.FullName,
                order.Technician.Phone,
                order.Technician.Email,
                order.Technician.Username,
                order.DeviceType.Name,
                order.Problem,
                order.Diagnosis,
                order.Status.Name,
                order.EstimatedCost,
                order.FinalCost,
                order.CompletedAt,
                order.UsedParts.Select(part =>
                    new UsedPartDto(
                        part.Id,
                        part.Quantity,
                        part.PricePerUnit,
                        part.PartId,
                        part.Part.Name,
                        part.RepairOrderId
                    )
                ).ToList()
            )).ToList();
        return dtos;
    }

    public async Task<RepairOrderDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new RepairOrderDto(
            entity.SerialNumber,
            entity.Client.FullName,
            entity.Client.Phone,
            entity.Client.Email ?? "",
            entity.TechnicianId,
            entity.Technician.FullName,
            entity.Technician.Phone,
            entity.Technician.Email,
            entity.Technician.Username,
            entity.DeviceType.Name,
            entity.Problem,
            entity.Diagnosis,
            entity.Status.Name,
            entity.EstimatedCost,
            entity.FinalCost,
            entity.CompletedAt,
            entity.UsedParts.Select(part =>
                new UsedPartDto(
                    part.Id,
                    part.Quantity,
                    part.PricePerUnit,
                    part.PartId,
                    part.Part.Name,
                    part.RepairOrderId
                )
            ).ToList()
        );
        return dto;
    }

    public async Task<bool> AddAsync(Guid clientId, Guid technicianId, Guid deviceTypeId, string problem, string diagnosis, decimal estimatedCost, decimal finalCost, Guid statusId)
    {
        try
        {
            var entity = RepairOrderEntity.Create(clientId, technicianId, deviceTypeId, problem, diagnosis, estimatedCost, finalCost, statusId);
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
    
    public async Task<bool> UpdateAsync(Guid id, Guid? clientId, Guid? technicianId, Guid? deviceTypeId, string? problem, string? diagnosis, decimal? estimatedCost, decimal? finalCost, Guid? statusId)
    {
        try
        {
            if (!clientId.HasValue && !technicianId.HasValue && !deviceTypeId.HasValue &&
                string.IsNullOrEmpty(problem) && string.IsNullOrEmpty(diagnosis) &&
                !estimatedCost.HasValue && !finalCost.HasValue && !statusId.HasValue)
            {
                throw new NullReferenceException();
            }
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            
            await _context.Database.BeginTransactionAsync();
            
            if (clientId.HasValue) entity.ClientId = clientId.Value;
            if (technicianId.HasValue) entity.TechnicianId = technicianId.Value;
            if (deviceTypeId.HasValue) entity.DeviceTypeId = deviceTypeId.Value;
            if (!string.IsNullOrEmpty(problem)) entity.Problem = problem;
            if (!string.IsNullOrEmpty(diagnosis)) entity.Diagnosis = diagnosis;
            if (estimatedCost.HasValue) entity.EstimatedCost = estimatedCost.Value;
            if (finalCost.HasValue) entity.FinalCost = finalCost.Value;
            if (statusId.HasValue) entity.StatusId = statusId.Value;
            
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
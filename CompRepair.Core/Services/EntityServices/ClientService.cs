using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices;

public class ClientService : BaseEntityService<ClientEntity>
{
    public async Task<List<ClientDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(x =>
            new ClientDto(
                x.Id, 
                x.FullName, 
                x.Email ?? "", 
                x.Phone, 
                x.BirthDate, 
                x.RepairOrders.Select(order => 
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
                    )
                ).ToList()
            )
        ).ToList();

        return dtos;
    }


    public async Task<ClientDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new ClientDto(
            entity.Id,
            entity.FullName,
            entity.Email ?? "",
            entity.Phone,
            entity.BirthDate,
            entity.RepairOrders.Select(order =>
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
                )
            ).ToList()
        );
        
        return dto;
    }

    public async Task<bool> AddAsync(string fullName, string? email, string phone, DateTime birthDate)
    {
        try
        {
            var entity = ClientEntity.Create(fullName, email, phone, birthDate);
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
    
    public async Task<bool> UpdateAsync(Guid id, string? fullName, string? email, string? phone, DateTime? birthDate)
    {
        try
        {
            if (fullName is null && email is null && phone is null && birthDate is null) throw new NullReferenceException();
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            
            await _context.Database.BeginTransactionAsync();
           
            if (fullName != null) entity.FullName = fullName;
            if (email != null) entity.Email = email;
            if (phone != null) entity.Phone = phone;
            if (birthDate != null) entity.BirthDate = birthDate;
            
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
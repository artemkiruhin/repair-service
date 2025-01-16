using CompRepair.Core.Models.DTOs;
using CompRepair.Core.Models.Entities;
using CompRepair.Core.Services.EntityServices.Base;
using Microsoft.EntityFrameworkCore;

namespace CompRepair.Core.Services.EntityServices;

public class UserService : BaseEntityService<UserEntity>
{
    public async Task<List<UserDto>> GetAllAsync()
    {
        var entities = await _dbSet.AsNoTracking().ToListAsync();
        var dtos = entities.Select(x =>
            new UserDto(
                x.Id,
                x.Username,
                x.FullName,
                x.Email,
                x.Phone,
                x.Salary,
                x.HiredDate,
                x.FiredDate ?? DateTime.MinValue,
                x.BirthDate,
                x.Role,
                x.RepairOrders.Select(o => new RepairOrderDto(
                    o.SerialNumber,
                    o.Client.FullName,
                    o.Client.Phone,
                    o.Client.Email ?? "",
                    o.TechnicianId,
                    o.Technician.FullName,
                    o.Technician.Phone,
                    o.Technician.Email,
                    o.Technician.Username,
                    o.DeviceType.Name,
                    o.Problem,
                    o.Diagnosis,
                    o.Status.Name,
                    o.EstimatedCost,
                    o.FinalCost,
                    o.CompletedAt,
                    o.UsedParts.Select(p => new UsedPartDto(
                        p.Id,
                        p.Quantity,
                        p.PricePerUnit,
                        p.PartId,
                        p.Part.Name,
                        p.RepairOrderId
                    )).ToList()
                )).ToList()
            )).ToList();
        return dtos;
    }

    public async Task<UserDto?> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        var dto = new UserDto(
            entity.Id,
            entity.Username,
            entity.FullName,
            entity.Email,
            entity.Phone,
            entity.Salary,
            entity.HiredDate,
            entity.FiredDate ?? DateTime.MinValue,
            entity.BirthDate,
            entity.Role,
            entity.RepairOrders.Select(o => new RepairOrderDto(
                o.SerialNumber,
                o.Client.FullName,
                o.Client.Phone,
                o.Client.Email ?? "",
                o.TechnicianId,
                o.Technician.FullName,
                o.Technician.Phone,
                o.Technician.Email,
                o.Technician.Username,
                o.DeviceType.Name,
                o.Problem,
                o.Diagnosis,
                o.Status.Name,
                o.EstimatedCost,
                o.FinalCost,
                o.CompletedAt,
                o.UsedParts.Select(p => new UsedPartDto(
                    p.Id,
                    p.Quantity,
                    p.PricePerUnit,
                    p.PartId,
                    p.Part.Name,
                    p.RepairOrderId
                )).ToList()
            )).ToList()
        );
        return dto;
    }

    public async Task<bool> AddAsync(string username, string fullName, string password, DateTime hiredDate, DateTime? firedDate, decimal salary, string phone, string email, DateTime birthDate, UserRole role = UserRole.Employee)
    {
        try
        {
            var userRole = role switch
            {
                UserRole.Employee => "Employee",
                UserRole.Admin => "Admin",
                _ => throw new ArgumentOutOfRangeException()
            };
            var entity = UserEntity.Create(username, fullName, password, hiredDate, firedDate,userRole, salary, phone, email, birthDate);
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

    public async Task<bool> UpdateAsync(Guid id, string? username, string? fullName, string? password,
        DateTime? hiredDate, DateTime? firedDate, decimal? salary, string? phone, string? email, DateTime? birthDate,
        UserRole? role)
    {
        try
        {
            if (string.IsNullOrEmpty(username)
                && string.IsNullOrEmpty(fullName)
                && string.IsNullOrEmpty(password)
                && !hiredDate.HasValue 
                && !firedDate.HasValue
                && !salary.HasValue
                && string.IsNullOrEmpty(phone)
                && string.IsNullOrEmpty(email)
                && !birthDate.HasValue 
                && !role.HasValue)
            {
                throw new NullReferenceException();
            }
            
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException();
            

            await _context.Database.BeginTransactionAsync();
            
            if (!string.IsNullOrEmpty(username)) entity.Username = username;
            if (!string.IsNullOrEmpty(fullName)) entity.FullName = fullName;
            if (!string.IsNullOrEmpty(password)) entity.Password = password;
            if (hiredDate.HasValue) entity.HiredDate = hiredDate.Value;
            if (firedDate.HasValue) entity.FiredDate = firedDate.Value;
            if (salary.HasValue) entity.Salary = salary.Value;
            if (!string.IsNullOrEmpty(phone)) entity.Phone = phone;
            if (!string.IsNullOrEmpty(email)) entity.Email = email;
            if (birthDate.HasValue) entity.BirthDate = birthDate.Value;
            if (role.HasValue)
            {
                var userRole = role.Value switch
                {
                    UserRole.Employee => "Employee",
                    UserRole.Admin => "Admin",
                    _ => throw new ArgumentOutOfRangeException()
                };
                entity.Role = userRole;
            }
            
            _dbSet.Update(entity);
            
            var result = await _context.SaveChangesAsync() > 0;
            await _context.Database.CommitTransactionAsync();

            return result;
        }
        catch (Exception e)
        {
            await _context.Database.RollbackTransactionAsync();
            throw new ApplicationException();
        }
    }
}
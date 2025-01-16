namespace CompRepair.Core.Models.DTOs;

public record UserDto(
    Guid Id,
    string Username,
    string FullName,
    string Email,
    string Phone,
    decimal Salary,
    DateTime HiredDate,
    DateTime FiredDate,
    DateTime BirthDate,
    string Role,
    List<RepairOrderDto> RepairOrders);
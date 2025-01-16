namespace CompRepair.Core.Models.DTOs;

public record ClientDto(Guid Id, string FullName, string Email, string Phone, DateTime? BirthDate, List<RepairOrderDto> RepairOrders);
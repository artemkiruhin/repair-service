namespace CompRepair.Core.Models.DTOs;

public record UsedPartDto(Guid Id, int Quantity, decimal PricePerPart, Guid PartId, string PartName, Guid RepairOrderId);
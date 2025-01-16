namespace CompRepair.Core.Models.DTOs;

public record PartDto (Guid Id, string Name, string Description, decimal Price, int StockQuantity, string CategoryName, string ManufacturerName, List<UsedPartDto> UsedParts);
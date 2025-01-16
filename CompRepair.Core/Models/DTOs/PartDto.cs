namespace CompRepair.Core.Models.DTOs;

public class PartDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } 
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string CategoryName { get; set; }
    public string ManufacturerName { get; set; }
    public List<UsedPartDto> UsedParts { get; set; } = [];
}
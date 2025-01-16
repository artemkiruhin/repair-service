namespace CompRepair.Core.Models.DTOs;

public class UsedPartDto
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerUnit { get; set; }
    public Guid PartId { get; set; }
    public string PartName { get; set; }
    public Guid RepairOrderId { get; set; }
}
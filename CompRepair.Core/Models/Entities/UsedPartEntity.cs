namespace CompRepair.Core.Models.Entities;

public class UsedPartEntity
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerUnit { get; set; }
    
    public Guid RepairOrderId { get; set; }
}
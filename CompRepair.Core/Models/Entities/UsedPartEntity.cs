namespace CompRepair.Core.Models.Entities;

public class UsedPartEntity
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerUnit { get; set; }
    
    public Guid PartId { get; set; }
    public virtual PartEntity Part { get; set; } = null!; 
    
    public Guid RepairOrderId { get; set; }
    public virtual RepairOrderEntity RepairOrder { get; set; } = null!;
}
namespace CompRepair.Core.Models.Entities;

public class RepairOrderEntity
{
    public Guid ClientId { get; set; }
    public Guid TechnicianId { get; set; }
    public string DeviceType { get; set; }
    public string SerialNumber { get; set; }
    public string Problem { get; set; }
    public string Diagnosis { get; set; }
    public Guid StatusId { get; set; }
    public decimal EstimatedCost { get; set; }
    public decimal? FinalCost { get; set; }
    public DateTime? CompletedAt { get; set; }
    
    public OrderStatusEntity Status { get; set; }
    public ClientEntity Client { get; set; }
    public UserEntity Technician { get; set; }
    public ICollection<UsedPartEntity> UsedParts { get; set; }
}
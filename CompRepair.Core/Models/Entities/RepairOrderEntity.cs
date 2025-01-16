namespace CompRepair.Core.Models.Entities;

public class RepairOrderEntity
{
    public Guid SerialNumber { get; set; }
    public Guid ClientId { get; set; }
    public Guid TechnicianId { get; set; }
    public Guid DeviceTypeId { get; set; }
    public string Problem { get; set; } = string.Empty;
    public string Diagnosis { get; set; } = string.Empty;
    public Guid StatusId { get; set; }
    public decimal EstimatedCost { get; set; }
    public decimal? FinalCost { get; set; }
    public DateTime? CompletedAt { get; set; }

    public virtual DeviceTypeEntity DeviceType { get; set; } = null!;
    public virtual OrderStatusEntity Status { get; set; } = null!;
    public virtual ClientEntity Client { get; set; } = null!;
    public virtual UserEntity Technician { get; set; } = null!;
    public virtual ICollection<UsedPartEntity> UsedParts { get; set; } = new List<UsedPartEntity>();
    
    public static RepairOrderEntity Create(Guid clientId, Guid technicianId, Guid deviceTypeId, string problem, string diagnosis, decimal estimatedCost, decimal finalCost, Guid statusId)
    {
        return new()
        {
            SerialNumber = Guid.NewGuid(),
            ClientId = clientId,
            TechnicianId = technicianId,
            DeviceTypeId = deviceTypeId,
            Problem = problem,
            Diagnosis = diagnosis,
            EstimatedCost = estimatedCost,
            FinalCost = finalCost,
            CompletedAt = DateTime.UtcNow,
            StatusId = statusId
        };
    }
}
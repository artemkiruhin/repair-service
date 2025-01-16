namespace CompRepair.Core.Models.DTOs;

public class RepairOrderDto
{
    public Guid SerialNumber { get; set; }
    public string ClientFullName { get; set; }
    public string ClientPhone { get; set; }
    public string ClientEmail { get; set; }
    public Guid TechnicianId { get; set; }
    public string TechnicianFullName { get; set; }
    public string TechnicianPhone { get; set; }
    public string TechnicianEmail { get; set; }
    public string TechnicianUsername { get; set; }
    public string DeviceTypeName { get; set; }
    public string Problem { get; set; } 
    public string Diagnosis { get; set; } 
    public string Status { get; set; }
    public decimal EstimatedCost { get; set; }
    public decimal? FinalCost { get; set; }
    public DateTime? CompletedAt { get; set; }
    public List<UsedPartDto> UsedParts { get; set; } = [];
}
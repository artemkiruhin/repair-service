namespace CompRepair.Core.Models.DTOs;

public record RepairOrderDto(
    Guid SerialNumber,
    string ClientFullName,
    string ClientPhone,
    string ClientEmail,
    Guid TechnicianId,
    string TechnicianFullName,
    string TechnicianPhone,
    string TechnicianEmail,
    string TechnicianUsername,
    string DeviceTypeName,
    string Problem,
    string Diagnosis,
    string Status,
    decimal EstimatedCost,
    decimal? FinalCost,
    DateTime? CompletedAt,
    List<UsedPartDto> UsedParts);
namespace CompRepair.Core.Models.DTOs;

public record LogDto (Guid Id, DateTime CreatedAt, Guid? UserId, string Message, string LogType);
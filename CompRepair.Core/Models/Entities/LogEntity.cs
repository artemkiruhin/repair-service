namespace CompRepair.Core.Models.Entities;

public class LogEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? UserId { get; set; }
    public string Message { get; set; }
    public string LogType { get; set; }

    public static LogEntity Create(DateTime createdAt, Guid? userId, string message, string logType)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            CreatedAt = createdAt,
            UserId = userId,
            Message = message,
            LogType = logType
        };
    }
}
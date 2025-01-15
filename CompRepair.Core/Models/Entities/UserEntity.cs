namespace CompRepair.Core.Models.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime HiredDate { get; set; }
    public DateTime? FiredDate { get; set; }
    public DateTime BirthDate { get; set; }
    public string Role { get; set; } = string.Empty;
}
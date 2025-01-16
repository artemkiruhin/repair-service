namespace CompRepair.Core.Models.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public string Password { get; set; } = string.Empty;
    public DateTime HiredDate { get; set; }
    public DateTime? FiredDate { get; set; }
    public DateTime BirthDate { get; set; }
    public string Role { get; set; } = string.Empty;
    
    public virtual ICollection<RepairOrderEntity> RepairOrders { get; set; } = new List<RepairOrderEntity>();
    
    public static UserEntity Create(string username, string fullName, string password, DateTime hiredDate, DateTime? firedDate, string role, decimal salary, string phone, string email, DateTime birthDate)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            Username = username,
            Password = password,
            HiredDate = hiredDate,
            FiredDate = firedDate,
            Role = role,
            Salary = salary,
            Phone = phone,
            Email = email,
            BirthDate = birthDate,
            FullName = fullName
        };
    }
}
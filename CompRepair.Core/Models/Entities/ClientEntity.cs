namespace CompRepair.Core.Models.Entities;

public class ClientEntity
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
    
    public virtual ICollection<RepairOrderEntity> RepairOrders { get; set; } = new List<RepairOrderEntity>();
    
    public static ClientEntity Create(string fullName, string? email, string phone, DateTime? birthDate)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            FullName = fullName,
            Email = email,
            Phone = phone,
            BirthDate = birthDate
        };
    }
}
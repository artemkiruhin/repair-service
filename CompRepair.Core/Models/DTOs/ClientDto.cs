namespace CompRepair.Core.Models.DTOs;

public class ClientDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; } 
    public string Email { get; set; } 
    public string Phone { get; set; } 
    public DateTime? BirthDate { get; set; }

    public List<RepairOrderDto> RepairOrders { get; set; } = [];
}
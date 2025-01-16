namespace CompRepair.Core.Models.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string Username { get; set; } 
    public string FullName { get; set; } 
    public string Email { get; set; } 
    public string Phone { get; set; } 
    public decimal Salary { get; set; }
    public DateTime HiredDate { get; set; }
    public DateTime FiredDate { get; set; }
    public DateTime BirthDate { get; set; }
    public string Role { get; set; }
    public List<RepairOrderDto> RepairOrders { get; set; } = [];
}
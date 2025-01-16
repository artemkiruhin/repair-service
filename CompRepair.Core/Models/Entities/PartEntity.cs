namespace CompRepair.Core.Models.Entities;

public class PartEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    
    public virtual ICollection<UsedPartEntity> UsedParts { get; set; } = new List<UsedPartEntity>();
    
    public Guid CategoryId { get; set; }
    public virtual CategoryEntity Category { get; set; } = null!;
    
    public Guid ManufacturerId { get; set; }
    public virtual ManufacturerEntity Manufacturer { get; set; } = null!;
    
    public static PartEntity Create(string name, string? description, decimal price, int stockQuantity, Guid categoryId, Guid manufacturerId)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            Name = name,
            Description = description,
            Price = price,
            StockQuantity = stockQuantity,
            CategoryId = categoryId,
            ManufacturerId = manufacturerId
        };
    }
}

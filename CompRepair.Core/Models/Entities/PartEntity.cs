﻿namespace CompRepair.Core.Models.Entities;

public class PartEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    
    public Guid ManufacturerId { get; set; }
    public ManufacturerEntity Manufacturer { get; set; } = null!;
}

﻿namespace CompRepair.Core.Models.Entities;

public class ManufacturerEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public virtual ICollection<PartEntity> Parts { get; set; } = new List<PartEntity>();
    
    public static ManufacturerEntity Create(string name)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            Name = name
        };
    }
}
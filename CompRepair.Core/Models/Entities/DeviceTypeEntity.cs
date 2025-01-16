﻿namespace CompRepair.Core.Models.Entities;

public class DeviceTypeEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public virtual ICollection<RepairOrderEntity> RepairOrders { get; set; } = new List<RepairOrderEntity>();
}